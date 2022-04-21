using System;
using System.ComponentModel;

namespace multi_controller.Properties {
    internal sealed partial class Customisation {
        
        public Customisation() 
        {
            this.PropertyChanged += this.PropertyChangingEventHandler;
        }

        private void PropertyChangingEventHandler(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "BorderWidth")
            {
                foreach (Client client in Controller.Instance.Collection.GetAllClients())
                {
                    client.Overlay.BorderWidth = this.BorderWidth;
                }
            }
            else
            {
                Controller.Instance.UpdateBorders();
            }
        }
    }
}
