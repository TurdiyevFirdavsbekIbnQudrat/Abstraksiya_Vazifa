using System.Text;
using Turtburchak_Yuza;
using SizeOfTriangle;
//Yuzalar nomli abstrakt klass bu yerda ikki holat ko'rib chiqilgan
// ya'ni uchburchak va to'rtburcha yuzalari ko'rib chiqilgan
abstract class Yuzalar
{
    public abstract void square_yuzi();
    public abstract void triangle_yuzi();
    
}

// umumiy holatda to'rtburchakning yuzini topish
class square: Yuzalar
{
    float a;
    float b;
    public square(float eni)
    {
        a = eni;
    }
    public square(float eni ,float boyi): this(eni)
    {
       b = boyi;
    }
    
    public override void square_yuzi()
    {   
        
        Console.WriteLine(yuza_4burchak.yuza4burchak(a,b));
    }

    public override void triangle_yuzi() { }
}

// uchburchakning yuzini topish
class triangle : Yuzalar
{   
    private float a;
    private float b;
    private float c;
    public triangle(float A ,float B,float C)
    {
        a = A;
        b = B;
        c = C;
    }
    public override void triangle_yuzi()
    {
        Console.WriteLine(Math.Sqrt(TriangleS.Uchburchakyuzi(a, b, c)));
    }

    public override void square_yuzi()
    {
    }

}
// Kvadrat -> bu yerda squaredan ya'ni to'rtburchaklar uchun umumiy yuzani chiqarib beruvchidan vorih oldim
class Kvadrat : square
{
    float a;   
    public Kvadrat(float eni) : base(eni)
    {
        a = eni;
    }
    public void kvadrat_yuzi()
    {
        Console.WriteLine(yuza_4burchak.yuza4burchak(a, a));
    }
    
}
public class Javoblar
{
    
    static void Main(string[] args)
    {

        square Turburchak = new square(12,23);
        Turburchak.square_yuzi();
        triangle Uchburchak = new triangle(3, 4, 5);
        Uchburchak.triangle_yuzi();
        Kvadrat KvadratYuzasiniTopish = new Kvadrat(13);
        KvadratYuzasiniTopish.kvadrat_yuzi();
    }
}