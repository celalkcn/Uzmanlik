abstract class Product
 {

    public int Id { get; set; }
    public string Name { get; set; }

    public abstract decimal CalculateDiscount();

 }

class Electronic:Product{
    public int Period { get; set; }

    public override decimal CalculateDiscount()
    {
        throw new NotImplementedException();
    }
}

class Food:Product{
    public override decimal CalculateDiscount()
    {
        throw new NotImplementedException();
    }

    public  int DateTime { get; set; }

}

interface IproductRepository{
    Product GetProductById(int id);
    List<Product> GetAll();

}



class ProductRepository : IproductRepository{
    public List<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public Product GetProductById(int id){
            return new Electronic {Id =id ,Name ="Iphone", Period =5 };
        }

    
}
 
 class OrderService 
 {
    private readonly IproductRepository _productRepository;

    public OrderService(IproductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public void ProcessOrder(int id){

    


     var product = _productRepository.GetProductById(id);
    // burada order ile ilgili işlemler yapılıyor...
  }

 }