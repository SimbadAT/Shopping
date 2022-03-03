
namespace Supermarket

{
    class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product> Products { get; set; }
        decimal PriceT = 0;
       

        public override decimal ValueToPay()
        {
            foreach (Product Market in Products)
            {
               PriceT += Market.ValueToPay();
            };
            return PriceT;
        }


        public override string ToString()
        {
            string listP=null;

            foreach (Product Market in Products)
            {
                listP += Market.Description+", ";  
            }
            return $"**Producto con Precio Compuesto**\n{Id}\t{Description}\n\tProductos.....:\t{listP}\n\tDescuento.....:\t{$"{Discount:p2}",15}\n\tValor.........:\t{$"{ValueToPay():c2}",15}";

        }
    }    
}