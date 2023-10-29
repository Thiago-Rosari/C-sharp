namespace Form_Especiais
{
    internal class Program
    {
        static void Main()
        {
            double valCompra = 4.00;
            double valVenda;
            double lucro = 0.4;
            string produto = "Pastel";

            valVenda = valCompra + (valCompra * lucro);

            Console.WriteLine("Produto........:{0,12}", produto);
            Console.WriteLine("Val.Compra.....:{0,12:c}", valCompra);
            Console.WriteLine("Lucro..........:{0,12:p}", lucro);
            Console.WriteLine("Val.Venda......:{0,12:c}", valVenda);



           
            // {0 = indice da variável | 12 = espacamento | :c = valor monetario / :p = porcentagem}
                    
        }
    }
}