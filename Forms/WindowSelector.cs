using System;
using System.Windows.Forms;

namespace multi_controller.Forms
{
    public partial class WindowSelector : Form
    {
        private bool addingWindows = false;
        private int groupNumber = 1;

        private bool addingLeft = false;
        private bool addingRight = false;

        private bool removingWindows = false;

        public WindowSelector()
        {
            InitializeComponent();

            UpdateWindowCountLabel();

            UpdateGroupComboBox();
            GroupSelectComboBox.SelectedIndex = 0;
        }

        private void UpdateWindowCountLabel()
        {
            WindowCountLabel.Text = $"Number of windows: {Controller.Instance.Collection.Groups[groupNumber - 1].Clients.Count}";
        }

        private void UpdateGroupComboBox()
        {
            GroupSelectComboBox.Items.Clear();
            for (int i = 0; i < Controller.Instance.Collection.Groups.Count; i++)
            {
                GroupSelectComboBox.Items.Add($"Group {i + 1}");
            }
        }

        private void AddLeftWindowsButton_Click(object sender, EventArgs e)
        {
            if (addingWindows)
            {
                addingLeft = false;
                Controller.Instance.ClientActivated -= ClientClicked;
                addingWindows = false;
                AddLeftWindowsButton.Text = "Add left windows";
            }
            else
            {
                addingLeft = true;
                Controller.Instance.ClientActivated += ClientClicked;
                addingWindows = true;
                AddLeftWindowsButton.Text = "Click windows...";
            }
        }

        private void AddRightWindowsButton_Click(object sender, EventArgs e)
        {
            if (addingWindows)
            {
                addingRight = false;
                Controller.Instance.ClientActivated -= ClientClicked;
                addingWindows = false;
                AddRightWindowsButton.Text = "Add right windows";
            }
            else
            {
                addingRight = true;
                Controller.Instance.ClientActivated += ClientClicked;
                addingWindows = true;
                AddRightWindowsButton.Text = "Click windows...";
            }
        }

        private void RemoveWindowButton_Click(object sender, EventArgs e)
        {
            if (removingWindows)
            {
                removingWindows = false;
                Controller.Instance.ClientActivated -= ClientClicked;
                RemoveWindowButton.Text = "Remove windows";
            }
            else
            {
                removingWindows = true;
                Controller.Instance.ClientActivated += ClientClicked;
                RemoveWindowButton.Text = "Click windows...";
            }
        }

        private void ClientClicked(object sender, ClientArgs e)
        {
            bool success = false;
            if (addingWindows)
            {
                Client client = new Client(e.handle);
                client.Overlay.Enable();

                success = Controller.Instance.Collection.Groups[groupNumber - 1].AddClient(client);
                Controller.Instance.UpdateBorders();

                if (addingLeft)
                {
                    client.ControlSet = ControlSet.Left;
                }
                else if (addingRight)
                {
                    client.ControlSet = ControlSet.Right;
                }
            }
            else if (removingWindows)
            {
                success = Controller.Instance.Collection.Groups[groupNumber - 1].RemoveClient(e.handle);
            }

            if (success)
            {
                UpdateWindowCountLabel();
            }
        }

        private void GroupSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupNumber = GroupSelectComboBox.SelectedIndex + 1;
            UpdateWindowCountLabel();
            Controller.Instance.Collection.SetActiveGroup(groupNumber);
        }

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            Controller.Instance.Collection.AddGroup();
            UpdateGroupComboBox();
            GroupSelectComboBox.SelectedIndex = GroupSelectComboBox.Items.Count - 1;
        }

        private void RemoveGroupButton_Click(object sender, EventArgs e)
        {
            Controller.Instance.Collection.RemoveGroup();
            int index = GroupSelectComboBox.SelectedIndex;
            UpdateGroupComboBox();
            if (index >= GroupSelectComboBox.Items.Count)
            {
                GroupSelectComboBox.SelectedIndex = GroupSelectComboBox.Items.Count - 1;
            }
        }

        private void WindowSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controller.Instance.ClientActivated -= ClientClicked;
        }
    }
}
