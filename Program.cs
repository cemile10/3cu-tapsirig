//3cu tapsirig
Console.WriteLine("ucreqemli eded daxil edin");
int eded = Convert.ToInt32(Console.ReadLine());

int eded1 = eded / 100;
int eded2 = (eded - (eded1 * 100)) / 10;
int eded3 = (eded - ((eded1 * 100) + (eded2 * 10)));

Console.WriteLine("ortadaki reqemi cixmis hali - " + (eded1) + eded3);

