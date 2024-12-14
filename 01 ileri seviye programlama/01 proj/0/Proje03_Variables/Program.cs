// string içinde \r ne işe yarar araştırınız 

// SENKRON!!!!!!!!!

// System.Console.WriteLine("1. İŞLEM (5 saniye )");

// for (int i = 1; i <= 5; i++)
// {
    
//     System.Console.WriteLine($"[\r1.işlem ] geçen süre: {i} sn");
//     Thread.Sleep(1000);
// }
// System.Console.WriteLine("1. İŞLEM (5 saniye ) sona erdi ");



// System.Console.WriteLine("2. İŞLEM (10 saniye )");

// for (int i = 1; i <= 10; i++)
// {
    
//     System.Console.WriteLine($"[\r2.işlem ] geçen süre: {i} sn");
//     Thread.Sleep(1000);
// }
// System.Console.WriteLine("2. İŞLEM (10 saniye ) sona erdi ");


// ASENKRON !!!!!!!!!

string task1Status= "5 saniyelik işlem bekleniyor...";
string task2Status = "10 saniyelik işlem bekleniyor...";

Thread thread1 = new Thread(()=>{

    for (int i = 1 ; i <= 5; i++)
    {
        task1Status =$"5 saniyelik işlem için geçen süre: {i} sn";
        Console.Clear();
        System.Console.WriteLine($"{task1Status}\n{task2Status} ");
        Thread.Sleep(1000);
    }
    task1Status = "5 saniyelik işlem Tamamlandı!";
    System.Console.WriteLine($"{task1Status}\n{task2Status} ");

});

Thread thread2 = new Thread(()=>{

    for (int i = 1 ; i <= 10; i++)
    {
        task2Status =$"10 saniyelik işlem için geçen süre: {i} sn";
        System.Console.WriteLine($"{task1Status}\n{task2Status} ");
        Thread.Sleep(1000);
    }
    task2Status = "10 saniyelik işlem Tamamlandı!";
    System.Console.WriteLine($"{task1Status}\n{task2Status} ");

});

thread1.Start();
thread2.Start();

