using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using RestoApp.Model;

namespace RestoApp.ViewModel
{
    class ClientViewModel
    {
        private Client client;

        public ClientViewModel(Client client)
        {
            this.client = client;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string NomClient
        {
            get
            {
                return client.nomClient;

            }
            set { client.nomClient = NomClient; }
        }

        public int IdClient
        {
            get
            {
                return client.idClient;

            }
            set { client.idClient = IdClient; }
        }
    }
}
