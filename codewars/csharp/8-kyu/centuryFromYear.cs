public static int СenturyFromYear(int year)
    => year % 100 == 0 ? year / 100 : (int)Math.Ceiling((double)year / 100);
