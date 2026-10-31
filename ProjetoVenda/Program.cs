using ProjetoVenda.view;

namespace ProjetoVenda
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            //Application.Run(new frmCadastroProduto());

            while (true)
            {
                using (frmLogin login = new frmLogin())
                {
                    if (login.ShowDialog() != DialogResult.OK)
                    {
                        break;
                    }
                }
                using (frmPrincipal principal = new frmPrincipal())
                {
                    Application.Run(principal);
                    if (principal.DialogResult != DialogResult.Retry)
                    {
                        break;
                    }
                }

            }



        }
    }
}