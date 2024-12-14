/*
Generic yapılar özellikle tip güvenliği sağlama 
konusunda işimizi görürler.Fakat aynı zamanda yeniden kullanabilirliği arttırır.




*/

// Dictionary <TKey,TValue>

Box<int> numberBox = new Box<int>();
numberBox.Add(5);
System.Console.WriteLine(numberBox.Get());

Box<string> stringBox = new Box<string>;
stringBox.Add("Aleyna");

System.Console.WriteLine(stringBox.Get());


class Box <T>

{

  private T content ;
  public void Add(T item)
{

    content=item;

}

 public T Get(){

return content;

 }


}