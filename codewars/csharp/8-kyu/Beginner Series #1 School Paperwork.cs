using System;
public static class Paper
{
    public static int Paperwork(int n, int m)
    {
        //n classmates 
        //m pages
        if (n >= 0 && m >= 0)
        {
            return n * m;
        }
        else
            return 0;
    }
}
