using Yapici_Metod_Constructor_ctor_Ornegi;

    class Program
    {
        static void Main(string[] args)
        {
            RegisterFormManager omer = new RegisterFormManager("omer5858", "omrfrk58", "omerfaruk@gmail.com");
            omer.userInfo();
            RegisterFormManager kerem = new RegisterFormManager("kero334", "kemik344", "kerem@gmail.com", "Kerem");
            kerem.userInfo();
            RegisterFormManager mert = new RegisterFormManager("mert55", "ibMertb", "mert@gmail.com", "Mert", "Çağlayan");
            mert.userInfo();
            RegisterFormManager emre = new RegisterFormManager("admin", "root123", "me@emrecelen.com.tr", "Emre", "Çelen", "05003300860");
            emre.userInfo();
        }
    }