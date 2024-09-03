using System;
using System.Collections.Generic;


namespace Proje.Models // MODEL kullanmak için 

{
    public static class Repository // uygulamayı kullanan herkes bellek üzerinde statik
    // olarak tanımlanmış bir alandan faydalanacak.
    {
        private static List<Candidate> applicaitons = new(); 

        public static IEnumerable<Candidate> Applications => applicaitons; // "readonly" bir özellik
        // sınıf dışından erişmek için arayüz desteğiyle kullanılması için oluşturulan özellik

        public static void Add(Candidate candidate)//formdan gelen elemanları ekler.
        {
            applicaitons.Add(candidate);
        }


    }
}