
namespace SizeOfTriangle
{
    
    public static class TriangleS
    {
        public static float Uchburchakyuzi(float a,float b,float c)
        {
            float p=(a+b+c)/2;
            p = p * Math.Abs(p - a) * Math.Abs(p - b) * Math.Abs(p - c);
            return p;
        }
    }

}