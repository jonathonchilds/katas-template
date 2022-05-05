public class MathCheck
{
    public static int AreaOrPerimeter(int l, int w)
    {

        if (l == w)
        {
            return l * w;
        }
        if (l != w)
        {
            return ((2 * l) + (2 * w));
        }
        else
            return 0;
    }
}