using System;

namespace MidtermProjectt
{
    class Program
    {
        static void Main(string[] args)

            // bu bölgede(region) proje için istediğiniz "adın ne?" sorusunu sordum
            #region 
        {   
            Console.WriteLine("Adın ne?");
            string playerName = Console.ReadLine();
            Console.WriteLine($"Merhaba {playerName}, sen İstinye Üniversitesi dijital oyun tasarımı öğrencisisin.");
            
            #endregion

            // bu bölgede 1. soruyu sordum burada verdiği cevaba göre soru dallanması olacaktır 2 3 4 sorular aynı fakat 1. soruya göre verilen cevapları farklı yaptım
            #region
            Console.WriteLine("Kaçıncı sınıf öğrencisisin? (a,b,c veya d cevabı olarak küçük harfle yanıtla)");
            Console.WriteLine("a-) 1\nb-) 2\nc-) 3\nd-) 4"); // "\n" parametresi sayesinde alt alta yazmak yerine yan yana yazarak alt alta output vermesini sağladım ve satır tasarrufu sağlamış oldum,
            string answer1 = Console.ReadLine();


            #endregion


            // bu bölgede eğer 1. soruda 1.sınıfım cevabı verildiyse şeklinde koşullu fonksiyonlarla farklı feedback vermesini sağladım.

            #region

            if (answer1 == "a")
            {
                // Soru 2 Favori ders sorusu
                Console.WriteLine("Soru 2: Hangisi favori dersin?");
                Console.WriteLine("a-) Writing & Storytelling\nb-) 2D design\nc-) Character Design\nd-) Basic Programing");
                string answer2 = Console.ReadLine();

                if (answer2 == "a")
                    Console.WriteLine("wow! Bu dersin öğretmeni Onur EREREN'dir, hikaye ve narrative yazmak çok heyecan verici. Bu yolda iyi ilerleyeceğine eminim.");
                else if (answer2 == "b")
                    Console.WriteLine("hey! Bu dersin öğretmeni Efe ERDOĞAN'dır, 2 boyutlu tasarımlar her zaman heyecan vericidir. Procreate, Aseprite gibi uygulamalar kullanarak kendini geliştirebilirsin.");
                else if (answer2 == "c")
                    Console.WriteLine("Bu dersin öğretmeni Efe ERDOĞAN'dır. Karakterler oyunun ana parçalarındandır. Kim bilir belki de favori karakterimiz olacak kişileri sen tasarlayacaksın.");
                else if (answer2 == "d")
                    Console.WriteLine("Bu dersin öğretmeni Timuçin UTKAN'dır. Programlama iyi tercih gibi görünüyor, kendini bu derste geliştirerek iyi bir geliştirici olabilirsin.");

                // Soru 3: Zorlandığın ders sorusu
                Console.WriteLine("\nBu derslerden hangisinde zorlandın?");
                Console.WriteLine("a-) Writing & Storytelling\nb-) 2D design\nc-) Character Design\nd-) Basic Programing");
                string answer3 = Console.ReadLine();

                if (answer3 == "a")
                    Console.WriteLine("Hikaye yazma kısmı gerçekten zor görünüyor, anlıyorum ama bunun için öğretmeninden yardım alman gerekebilir.");
                else if (answer3 == "b")
                    Console.WriteLine("Tasarım kısmı bazen can sıkıcı olabilir ama bunda yetenekli olmak istiyorsan çok çalışmalısın.");
                else if (answer3 == "c")
                    Console.WriteLine("Karakter tasarımı aslında eğlencelidir, eğer çalışıp yeterli araştırmalar yaparsan karakter tasarımında eğlenip kendini geliştirebilirsin.");
                else if (answer3 == "d")
                    Console.WriteLine("Ah, şu programlama... Herkes için zorlayıcıdır aslında değil mi? Bir sürü fonksiyon ve bilinmeyen kelime... Hayır, daha yolun başındasın ve önünde uzun bir yol var, pes etme.");

                // Soru 4: Tasarım mı Programlama mı pozisyon sorusu
                Console.WriteLine("\nTasarım veya Programlama birini seçmek zorunda olsaydın hangisi olurdu?");
                Console.WriteLine("a-) Tasarım\nb-) Programlama");
                string answer4 = Console.ReadLine();

                if (answer4 == "a")
                    Console.WriteLine("Daha yolun başındasın ve elbetteki 4. yılın sonunda ve şu anki halin arasında dağlar kadar fark olacaktır. Tasarım her yıl kendini daha çok geliştirdiğin bir alandır.");
                else if (answer4 == "b")
                    Console.WriteLine("Programlama birçok dili olan ucu olmayan bir serüvendir, şu an sadece Python gördün ama bu yol çok uzun. Buna karşı motivasyonunu kaybetme.");
            }

            #endregion

            // bu bölgede eğer 1. soruda 2.sınıfım cevabı verildiyse şeklinde koşullu fonksiyonlarla farklı feedback vermesini sağladım.

            #region


            else if (answer1 == "b")
            {
                // Soru 2 Favori ders sorusu
                Console.WriteLine("Soru 2: Hangisi favori dersin hangisi?");
                Console.WriteLine("a-) 3D Animation\nb-) Game Programing\nc-) Game Develope Pipeline\nd-) 3D Modeling");
                string answer2 = Console.ReadLine();

                if (answer2 == "a")
                    Console.WriteLine("Bu dersin öğretmeni Can TANYELİ'dir, öğrencilere sorulduğunda çoğunun en zor diyeceği ders olabilir. Yazılım arayüzüne alıştıktan sonra kesinlikle birçok şey daha kolay yapılır.");
                else if (answer2 == "b")
                    Console.WriteLine("Bu dersin öğretmeni Onur EREREN'dir, programcı her oyun üretim grubunun vazgeçilmez aranan oyuncusudur.");
                else if (answer2 == "c")
                    Console.WriteLine("Bu dersin öğretmeni Togay KURTULUŞ'tur, Unreal Engine motoruyla oyun yaratmak üzerine yapılan bir derstir. Başarılı olmak çok adım önde olmak demektir.");
                else if (answer2 == "d")
                    Console.WriteLine("Bu dersin öğretmeni Can TANYELİ'dir, modelleme 3D oyunlarının temel parçasıdır. Bu dersin favori dersin olması sana çok fazla getirisi olacaktır.");

                // Soru 3: Zorlandığın ders sorusu
                Console.WriteLine("\nBu derslerden hangisinde zorlandın?");
                Console.WriteLine("a-) 3D Animation\nb-) Game Programing\nc-) Game Develope Pipeline\nd-) 3D Modeling");
                string answer3 = Console.ReadLine();

                if (answer3 == "a")
                    Console.WriteLine("Bu derste senin gibi birçok kişi zorlandığına emin ol. Ama dersin parametrelerini öğrendikten sonra işler çok daha kolay ilerleyecek.");
                else if (answer3 == "b")
                    Console.WriteLine("Tahmin edeyim, sen bir tasarımcısın :) Bireysel çalışmalarda oyun motorlarında bu yazılım diliyle oyun yazıldığı için bu konuda eksiğin olması endişe verici olabilir, ama bunda gelişmek imkansız değildir.");
                else if (answer3 == "c")
                    Console.WriteLine("Bu dersin anlatımı Unreal Engine üzerinden. Belki farklı oyun motorlarını denersen (örneğin; Unity) bu ders hakkındaki düşüncelerin değişebilir.");
                else if (answer3 == "d")
                    Console.WriteLine("Bu dersten eksiğin varsa hemen tamamlaman gerekir çünkü oyun motoru, animasyon ve diğer birçok dersin temeli bu dersten geçer.");

                // Soru 4: Tasarım mı Programlama mı pozisyon sorusu
                Console.WriteLine("\nTasarım veya Programlama birini seçmek zorunda olsaydın hangisi olurdu?");
                Console.WriteLine("a-) Tasarım\nb-) Programlama");
                string answer4 = Console.ReadLine();

                if (answer4 == "a")
                    Console.WriteLine("Kendini bulduğun ve keşfettiğin zamanlardasın. Tasarım çok güzel bir alan, bunun için 3D Modeling, 3D Animation derslerine dikkat etmelisin.");
                else if (answer4 == "b")
                    Console.WriteLine("Kendini bulduğun ve keşfettiğin zamanlardasın. Bu pozisyonda iyi olmak için Game Programing ve Pipeline derslerini iyi geçirmiş olman gerekir.");
            }


            #endregion

            // bu bölgede eğer 1. soruda 3.sınıfım cevabı verildiyse şeklinde koşullu fonksiyonlarla farklı feedback vermesini sağladım.

            #region

            else if (answer1 == "c")
            {
                // Soru 2 Favori ders sorusu
                Console.WriteLine("Soru 2: Hangisi favori dersin hangisi?");
                Console.WriteLine("a-) Networking\nb-) Game Engine\nc-) Branding");
                string answer2 = Console.ReadLine();

                if (answer2 == "a")
                    Console.WriteLine("Bu dersin öğretmeni Meric ERYÜREK'tir. Bu ders daha genel, o yüzden kendini her zaman geliştirmen gerek.");
                else if (answer2 == "b")
                    Console.WriteLine("Bu dersin öğretmeni Onur EREREN'dir, oyun inşası oyunun temel yapıtaşlarındandır.");
                else if (answer2 == "c")
                    Console.WriteLine("Bu dersin öğretmeni Can TANYELİ'dir, öğrendiğin tasarımları belli bir hiyerarşiye dökmek heyecan verici.");

                // Soru 3: Zorlandığın ders sorusu
                Console.WriteLine("\nBu derslerden hangisinde zorlandın?");
                Console.WriteLine("a-) Networking\nb-) Game Engine\nc-) Branding");
                string answer3 = Console.ReadLine();

                if (answer3 == "a")
                    Console.WriteLine("Ağ hizmetinde eksiklerin olabilir, en azından temel bilgileri edinmende fayda olacaktır.");
                else if (answer3 == "b")
                    Console.WriteLine("Bu derste eksiklerin büyük bir eksiktir. Öndeki dersteki eksikler kapatılmalı.");
                else if (answer3 == "c")
                    Console.WriteLine("Bu dersin eksik olması kötüye işaret olabilir, tasarım anlamında eksikleri gidermen sağlıklı olacaktır.");

                // Soru 4: Tasarım mı Programlama mı pozisyon sorusu
                Console.WriteLine("\nTasarım veya Programlama birini seçmek zorunda olsaydın hangisi olurdu?");
                Console.WriteLine("a-) Tasarım\nb-) Programlama");
                string answer4 = Console.ReadLine();

                if (answer4 == "a")
                    Console.WriteLine("Digital Game Branding and Product Design dersinden eksiklerin olmaması lazım.");
                else if (answer4 == "b")
                    Console.WriteLine("C# dilini ve oyun motorlarını daha iyi öğrenmen gerekecek. Bu derslerde sağlam bir temel oluşturman çok önemli.");
            }

            #endregion

            // bu bölgede eğer 1. soruda 4.sınıfım cevabı verildiyse şeklinde koşullu fonksiyonlarla farklı feedback vermesini sağladım.

            #region


            else if (answer1 == "d")
            {
                // Soru 2 Favori ders sorusu
                Console.WriteLine("Soru 2: Hangisi favori dersin?");
                Console.WriteLine("a-) Project Management\nb-) VR & AR Design\nc-) Game AI\nd-) Digital Sculpting");
                string answer2 = Console.ReadLine();

                if (answer2 == "a")
                    Console.WriteLine("Proje yönetimi seni çok iyi yönlendirecek. İyi bir proje yöneticisi, oyun yapım sürecini verimli hale getirebilir.");
                else if (answer2 == "b")
                    Console.WriteLine("VR & AR Design dersini sevmen çok anlamlı. Bu ders, gelecekteki teknolojilerin merkezinde yer almanızı sağlar.");
                else if (answer2 == "c")
                    Console.WriteLine("AI, oyunlardaki zeka işleyişinin temelidir. Bu dersi seviyorsan, oyun yapımındaki zorlukların üstesinden gelmen kolaylaşır.");
                else if (answer2 == "d")
                    Console.WriteLine("Dijital heykel tasarımı yaratıcı süreçlerin kalbidir. Tasarım konusunda derinleşmen ve becerilerini arttırman çok faydalı olacak.");

                // Soru 3: Zorlandığın ders sorusu
                Console.WriteLine("\nBu derslerden hangisinde zorlandın?");
                Console.WriteLine("a-) Project Management\nb-) VR & AR Design\nc-) Game AI\nd-) Digital Sculpting");
                string answer3 = Console.ReadLine();

                if (answer3 == "a")
                    Console.WriteLine("Proje yönetimi başlangıçta zor olabilir, çünkü birçok detay var ama zamanla alışman ve güçlü bir yönetici olman mümkün.");
                else if (answer3 == "b")
                    Console.WriteLine("VR ve AR teknolojileri gelişmekte olan alanlar. Bu alanda başarılı olmak için oldukça fazla pratik yapman ve araştırman gerekiyor.");
                else if (answer3 == "c")
                    Console.WriteLine("AI yazılımı zorlayıcı olabilir ama dilin temelini öğrendikten sonra oyunlarda zeka işleyişi hakkında büyük fikirler geliştirebilirsin.");
                else if (answer3 == "d")
                    Console.WriteLine("Dijital heykel tasarımı başta karmaşık görünebilir, ancak daha fazla pratiğe dayalı bir süreç olduğu için giderek daha iyi olacaksın.");

                // Soru 4: Tasarım mı Programlama mı pozisyon sorusu
                Console.WriteLine("\nTasarım veya Programlama birini seçmek zorunda olsaydın hangisi olurdu?");
                Console.WriteLine("a-) Tasarım\nb-) Programlama");
                string answer4 = Console.ReadLine();

                if (answer4 == "a")
                    Console.WriteLine("Tasarım her zaman bir adım önde olabilir, çünkü oyunların görsel ve kullanıcı deneyimini şekillendirir. Bu yüzden tasarımda kendini geliştirmen önemli.");
                else if (answer4 == "b")
                    Console.WriteLine("Programlama her zaman daha teknik bir alandır, ancak oyunları hayata geçirebilmek için bu beceriyi geliştirmek zorundasın.");
            }


            #endregion

        }
    }
}


// AÇIKLAMA

#region

// Bu projede geçen yılki python bilgilerimle, game programing dersinde öğrettiklerinizle , kadim dostum ChatGPT'yle (çıkan bazı hataları düzeltme ve kodun hiyerarşisini sağlamada) ve diğer C# eğitim video ve kaynaklarından yararlanarak yaptım.

// Bu projede bölümümüzün güncel öğretim programından (https://ois.istinye.edu.tr/bilgipaketi/eobsakts/ogrenimprogrami/program_kodu/0504001/menu_id/p_33/tip/L/ln/tr/submenuheader/2) baz alarak dallanmalı sorular sordum.

// Outputta önce isim sorulur sonra 1. soruda verilen cevaba göre 2 3 ve 4. sorular ard arda sorulur, sorular aynı cevaplar 1. soruya göre feedbackler ise 2 3 ve 4. sorulara verilen yanıtlara göre verilir.

// Derste gösterdiğiniz sınıf(class) parametresini kullanarak başladığım kodda string outputu için Console.Writeline fonksiyonunu (python'da printle aynı işlevi görüyo) kullandım.
// Aynı zamanda kullanıcının cevap vermesi için Console.ReadLine (pythonda input işlevi görüyo) fonksiyonunu kullanarak kullanıcıya sunduğum seçeneklerin geridönüşünü almamı sağladım.
// Aldığım geridönüşümlerle bu dersimizin 4.haftasından değindiğimiz aynı zamanda python'dan da aşina olduğum if\else-if(elif)\else parametrelerini kullanarak koşul ekleyip ona göre feedback outputlayacak şekilde kod oluşturdum

// adın ne gibi soruları sorarken string yazılarının yanına atanan değerleri koymak için "$" ifadesini kullandım.

// #region ve #endregion ile n\ parametrelerini kullanarak daha düzenli ve satır tasarrufu olacak şekilde kod yazdım. 

#endregion