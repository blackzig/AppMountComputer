using AppMountComputer.Banco;
using AppMountComputer.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMountComputer.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MinhasPecas : ContentPage
	{
        List<Processador> lista { get; set; }

        public MinhasPecas ()
		{
			InitializeComponent ();

            Database database = new Database();
            lista = database.Consultar();
            ListaProcessadores.ItemsSource = lista;

            lblCount.Text = lista.Count.ToString();
        }

        public void EditarAction(object sender, EventArgs args)
        {

        }

        public void ExcluirAction(object sender, EventArgs args)
        {

        }
    }
}