public interface Hayvanlar
{
    void Ucmak();
    void Kosmak();
    void Havlama();
}

public class Kus: Hayvanlar
{
    public void Ucmak()
    {
        Console.WriteLine("Kuşlar uçabilir");

    }
    public void Kosmak()
    {
        Console.WriteLine("Kuşlar koşabilir");
    }
    public void Havlama()
    {
        //Bu özellik kuşlarda yok fakat aynı interface içinde
        //kullandığımız için tanımlamak zorunda kalıyoruz.
    }
}