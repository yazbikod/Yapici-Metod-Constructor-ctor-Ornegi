using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Yapici_Metod_Constructor_ctor_Ornegi
{
    class RegisterFormManager
    {
        ///---> Değişken Tanımlamaları <---\\\
        ///---> Zorunlu Alanlar:
        string userName, userPass, eMail;
        ///---> Tercihen Doldurulabilir Alanlar:
        string name, surName;
        string phoneNumber;
        ///---> Tarih Bilgisinin Tutulacağı Alan:
        DateTime date;
        ///---> Ayraç Tanımlaması:
        string ayrac = new string('-', 20);
        ///---> Constructor Metot Tanımlamaları <---\\\
        public RegisterFormManager(string userName, string userPass, string eMail)
        {
            controlMethod(userName, userPass, eMail, "", "", "");
        }
        public RegisterFormManager(string userName, string userPass, string eMail, string name)
        {
            controlMethod(userName, userPass, eMail, name, "", "");
        }
        public RegisterFormManager(string userName, string userPass, string eMail, string name, string surName)
        {
            controlMethod(userName, userPass, eMail, name, surName, "");
        }
        public RegisterFormManager(string userName, string userPass, string eMail, string name, string surName, string phoneNumber)
        {
            controlMethod(userName, userPass, eMail, name, surName, phoneNumber);
        }

        ///---> Kontrol Metot Tanımlaması <---\\\
        void controlMethod(string userName, string userPass, string eMail, string name, string surName, string phoneNumber)
        {
            if (userName.Length >= 5)
            {
                if (userPass.Length >= 6)
                {
                    if (eMail.Contains('@') && eMail.Contains('.') && eMail.Length > 13)
                    {
                        if (name.Length > 0)
                            this.name = name;
                        else
                            this.name = null;
                        if (surName.Length > 0)
                            this.surName = surName;
                        else
                            this.surName = null;
                        if (phoneNumber.Length == 11)
                            this.phoneNumber = phoneNumber;
                        this.userName = userName;
                        this.userPass = userPass;
                        this.eMail = eMail;
                        this.date = DateTime.Now;
                        Console.WriteLine("{0}\n<Kullanıcı Bilgileri Sistemimize Kayıt Edildi>\n{1}", ayrac, ayrac);
                    }
                    else
                        Console.WriteLine("{0}\n-> Mail Adresinizi Tanımsız Girdiniz.\n{1}", ayrac, ayrac);
                }
                else
                    Console.WriteLine("{0}\n-> Kullanıcı Şifreniz 6 Karakterden Kısa Olamaz.\n{1}", ayrac, ayrac);
            }
            else
                Console.WriteLine("{0}\n-> Kullanıcı İsminiz 5 Karakterden Kısa Olamaz.\n{1}", ayrac, ayrac);
        }
        ///---> Kullanıcı Bilgilerini Yazdıralım <---\\\
        public void userInfo()
        {
            if (userName != null && userPass != null && eMail != null)
            {
                Console.WriteLine("-> Kullanıcı Kayıt Tarihi: {0}", date);
                if (name != null && surName == null)
                    Console.WriteLine("{0}\n<Kullanıcı Bilgileri>\n{1}\n-> Kullanıcı Adı: {2}\n-> Kullanıcı Şifresi: {3}\n-> Kullanıcı Mail Adresi: {4}\n-> Kullanıcının İsmi: {5}\n{6}", ayrac, ayrac, userName, userPass, eMail, name, ayrac);
                else if (name != null && surName != null && phoneNumber == null)
                    Console.WriteLine("{0}\n<Kullanıcı Bilgileri>\n{1}\n-> Kullanıcı Adı: {2}\n-> Kullanıcı Şifresi: {3}\n-> Kullanıcı Mail Adresi: {4}\n-> Kullanıcının İsmi: {5}\n-> Kullanıcı Soyismi: {6}\n{7}", ayrac, ayrac, userName, userPass, eMail, name, surName, ayrac);
                else if (name != null && surName != null && phoneNumber != null)
                    Console.WriteLine("{0}\n<Kullanıcı Bilgileri>\n{1}\n-> Kullanıcı Adı: {2}\n-> Kullanıcı Şifresi: {3}\n-> Kullanıcı Mail Adresi: {4}\n-> Kullanıcının İsmi: {5}\n-> Kullanıcı Soyismi: {6}\n-> Telefon Numarası: {7}\n{8}", ayrac, ayrac, userName, userPass, eMail, name, surName, phoneNumber, ayrac);
                else
                    Console.WriteLine("{0}\n<Kullanıcı Bilgileri>\n{1}\n-> Kullanıcı Adı: {2}\n-> Kullanıcı Şifresi: {3}\n-> Kullanıcı Mail Adresi: {4}\n{5}", ayrac, ayrac, userName, userPass, eMail, ayrac);
            }
            else
                Console.WriteLine("\n{0}\n<Kullanıcı Bilgileri Sistemde Bulunamadı>\n{1}", ayrac, ayrac);
        }
    }
}