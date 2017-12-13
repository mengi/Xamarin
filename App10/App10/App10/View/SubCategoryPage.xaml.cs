using App10.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App10.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubCategoryPage : ContentPage
    {
        public SubCategoryPage(TopCategoryModel topModel)
        {
            InitializeComponent();
            this.Title = topModel.topTitle;

            List<SubCategoryModel> listSubCategory = new List<SubCategoryModel>();
            listSubCategory.Add(new SubCategoryModel
            {
                subId = 1,
                topReferenceId = 1,
                subTitle = "Yüz ve Dudak Dolgusu",
                subDesc = "<h3>Yüz Dolgu Maddeleri</h3><p>Yerleşmiş cilt kırışıklıklarının giderilmesi, dudak dolgunlaştırma, yüze volum verme " +
                "ve yeniden şekillendirme gibi cilt gençleştirme işlemleri ile skar ve atrofik cilt dokularının yükseltilmesinde" +
                "çeşitli yüz dolgu maddeleri kullanılmaktadır.Bunlar arasında, en çok kullanılan yüz dolgu maddeleri;<br/>" +
                "<ul> <li>hyalüronik asit ve </li> <li>kalsiyum apatit kristalleri</li> </ul><br/>içeren yüz dolgu maddeleridir.</p>" +
                "<p>Hyaluronik asit normal dermis dokusunu oluşturan temel bir ara maddedir.Hacminin 1000 katı" +
                " su bağlama kapasitesine sahiptir.İçerdiği çapraz bağlar sayesinde uygulandıkları bölgede uzun süre kalırlar.Hyaluronik asit içeren bu yüz dolgu maddeleri enjekte edildikleri bölgede yer değiştirmedikleri" +
                "ve alerjik reaksiyonlara neden olmadıkları için yumuşak dokunun hacminin arttırılmasına yardımcı olurlar. " +
                "Hyaluronik asit içeren yüz dolgu maddelerinin kalıcılıkları çapraz bağ sayısına ve üretim şekline göre " +
                "6-18 ay arasındadır. Bu ürünler lokal anestezi ile rahatlıkla uygulanabilirler.</p>",
                subImageUrl = "dolgu.jpg"
            });

            listSubCategory.Add(new SubCategoryModel
            {
                subId = 1,
                topReferenceId = 1,
                subTitle = "Göz Altı Işık Dolgusu ",
                subDesc = "Gözler, kişinin yüzünde ilk bakışta farkedilen ve yüzün estetik görünümünde en önemli bölgedir.Kişinin mutlu mu, üzgün mü, sinirli mi veya yorgun mu olduğunu gözlerine bakarak anlarız." +
                    "<p>Gözlerin altındaki mor halkalar yaş ilerledikçe daha çok dikkat çekmeye başlar.Ancak bazen genetik yapımızla" +
                    "alakalı olarak çok genç yaşlarda da ortaya çıkabilir.Gözaltı morlukları kişiyi yorgun ve hasta gösterir. Bazen de gözaltı çöküklüğü" +
                   "öyle fazla olur ki bu durum gözaltı torbalarının daha da belirgin görünmesine sebep olur. </p>" +
                    "<p>Gözaltına son dönemde uygulanmaya başlanan dolgular ile bu yorgun ve mor görüntü çok büyük oranda" +
                    "azaltılabilmektedir.</p>" +
                    "<p>Gözaltı ışık dolgusu da denilen bu dolgu serbest ve bağlı hyaluronik asit, vitaminler ve antioksidanlar içermektedir." +
                    "Dolayısıyla hem gözaltındaki boşluğu doldurmakta hem de gözaltı morluğuna neden olan gevşek  bağ dokusunu onarmaktadır.İnce bağ dokusu" +
                   "yüzünden görünen damar yapıları gözaltı ışık dolgusu kapatarak, gözaltı morluğunu azaltmaktadır.</p>" +
                    "<p>Uygulama 15-20 dakika sürmektedir ve etkisi yaklaşık 1 yıl devam etmektedir.</p>",
                subImageUrl = "goz_alti_isik_dolgusu.jpg"
            });

            listSubCategory.Add(new SubCategoryModel
            {
                subId = 1,
                topReferenceId = 2,
                subTitle = "Fraksiyonel CO2 Lazer",
                subDesc = "Normal yaşlanma prosesine, güneş hasarı ve hava kirliliğinin zararlı etkileri de" +
                    "eklendiğinde kollajen yıkımı hızlanır.Konnektif dokunun esas proteni olan kollajenin ciltteki miktarı" +
                    "azaldıkça kırışıklıklar gözlenmeye başlar.Cilt gençleştirmede (antiaging) kullanılan fraksiyonel CO2" +
                    "lazerler, tüm cilt yüzeyini etkileyen konvansiyonel CO2 lazerlerin aksine ciltte mikroskobik kolonlar" +
                    "açarlar. Bu bölgelerdeki esas hedef sudur, yani kollajen, kan damarları, keratinositler gibi su içeren" +
                    "yapılar, seçici termal hasara uğrarlar. Termal hasar oluşan bölgenin hemen yanındaki hasar görmemiş" +
                    "bölgelerdeki canlı hücreler hasarlı alana göç ederek buradaki onarım mekanizmasını uyarırlar.Böylece" +
                    "cilt altında yeni kollajen üretimi başlar.Yeni jenerasyon fraksiyonel CO2 lazerlerin en büyük özelliği" +
                    "cildin üst yüzeyine hasar vermeden işlevini cildin altında gerçekleştirmesi ve böylece iyileşmenin çok" +
                    "daha hızlı gerçekleşerek kişilerin sosyal hayatlarına kısa süre içinde dönmelerini sağlamalarıdır.</p>	" +
                    "<h3>Fraksiyonel CO2 lazer uygulamaları hangi alanlarda kullanılmaktadır?</h3>" +
                    "<br/>" +
                        "<ul><li>Akne izleri</li><li>Ameliyat izi</li><li>Yanık ve yara izi</li><li>Gebelik ve doğum sonrası çatlakları</li>" +
                            "<li>Cilt kırışıklıkları ve cilt sıkılaştırma</li>" +
                            "<li>Yaşlılık ve güneş lekelerinin giderilmesi</li>" +
                            "<li>Gebelik maskesi (melasma)</li></ul><br/></p>",
                subImageUrl = "leke.jpg"
            });

            listSubCategory.Add(new SubCategoryModel
            {
                subId = 1,
                topReferenceId = 2,
                subTitle = "Q-Switched Nd:YAG Lazer",
                subDesc = "<h3>Q-Switched Nd:YAG Lazerlerin Kullanım Alanları Nerelerdir?</h3>" +
                    "Yeni geliştirilmiş ve enerjiyi eşit dağıtan Q-Switched Nd: YAG lazerler, farklı cilt" +
                     "tonlarında, farklı uygulamalarda kullanılmaktadırlar.Çevredeki canlı hücrelere zarar vermeden dövmeleri" +
                     "ve kalıcı makyajı silebilmektedirler.Dövme mürekkebi lazer ışığını emdikten sonra çok küçük parçalara" +
                     "ayrılmakta böylece vücudun savunma mekanizmasında bulunan hücreler tarafından yok edilmektedirler." +
                    "<p>Q-Switched Nd:YAG lazerler ile güneş, yaşlılık, doğum lekeleri ve melazma da(melasma)" +
                    "tedavi edilebilmektedir.Hastada herhangi bir kabuklanma oluşmadan lekeler uygulanan seanslar ile giderek" +
                    "açılmaktadır.</p>" +
                    "<p>Q-Switched Nd:YAG lazerler aynı zamanda cilt yenilemede, gözeneklerin azaltılmasında," +
                    "yüzdeki yağ dengesinin sağlanmasında, akne ve akne izlerinin tedavisinde de kullanılmaktadırlar.Karbon" +
                    "bazlı losyon ile uygulanan işlem, fototermal etki yaparak cildin yenilenme sürecini harekete geçirir.</p>	",
                subImageUrl = "goz_alti_isik_dolgusu.jpg"
            });

            listSubCategory.Add(new SubCategoryModel
            {
                subId = 1,
                topReferenceId = 3,
                subTitle = "Bölgesel Zayıflama",
                subDesc = "Beslenme alışkanlıkları, genetik yapı ve diğer çeşitli etkenlerden dolayı," +
                     "vücudun göbel, bel, basen gibi bölgelerinde diğer bölgelere oranla daha fazla yağlanma meydana gelmektedir." +
                     "Bazen diyet ve spor gibi aktivitelerle bu fazla yağları yakmak mümkün olurken çoğu kez sonuç hiç değişmemekte" +
                     "ve farklı tedavi yöntemleri uygulanmaktadır." +
                    "<p>Bölgesel zayıflama, vücudun farklı bölgelerinde oluşan yağ fazlalıklarının azaltılmasını sağlayanyöntem ve uygulamaların tümünü kapsamaktadır.</p> " +
                    "<p>Bölgesel incelme yöntemleri ile yağ hücrelerinin parçalanarak katı halden sıvı hale geçmesi sağlanır" +
                    "ve yağlar vücut tarafından kullanılarak yakılmış olur.</p>" +
                    "<p>Bölgesel zayıflama amacıyla, mezoterapi, kavitasyon, lipoliz gibi amaliyatsız yöntemlerin yanı sıra liposuction" +
                    "gibi çeşitli cerrahi yöntemler kullanılmaktadır.Ayrıca, bölgesel incelmeyi sağlayan çeşitli cihaz ve teknolojilerde" +
                    "mevcuttur.</p>",
                subImageUrl = "bolgesel.jpg"
            });

            listSubCategory.Add(new SubCategoryModel
            {
                subId = 1,
                topReferenceId = 3,
                subTitle = "Selülit Tedavisi",
                subDesc = "Selülit(hidrolipodistrofi), yağ hücrelerinin mikrosirkülasyon bozukluğu sonucu" +
                    "içeriklerinin artması ile başlar.Yağ hücreleri içinde bulundukları odacıkları oluşturan ve elastik" +
                   " olmayan bağ dokusuna baskı yaparlar ve dolayısıyla cildi yüzeye doğru iterler.Elastik olmayan bağ dokusu" +
                    "septaları da cildi aşağı doğru çekerler ve bu karşılıklı itme ve çekme de cilt yüzeyinde portakal kabuğu" +
                    "görünümünü yaratır.<br>" +
                    "<h3>Selülit Oluşumuna Neden Olan Faktörler Nelerdir?</h3>" +
                    "<p><br/>" +
                        "<ul>" +
                             "<li>Dolaşımın bozuk olması: Fiziksel aktivite azlığı ve yetersiz su tüketimi dolayısıyla Lenfatik dolaşımın bozulması selülitin oluşmasına zemin hazırlar.</li>" +
                             "<li>Hormonal dengelerde bozulma: Östrojen, septaların zayıflamasına ve yağ hücrelerini içinde barındıramayıp dermis içine doğru ilerleyerek portakal kabuğu görünümünün oluşmasında bir etkendir.</li>" +
                             "<li>Egzersiz azlığı: Kan dolaşımının bozulması ve yağ depolanmasının artışı selülite zemin hazırlamaktadır.</li>" +
                             "<li>Kötü beslenme: Özellikle yağlı yiyecekler, alkol, kafein ve şeker selülit oluşumunda büyük rol oynar.</li>" +
                             "<li>Yetersiz su alımı: Toksinlerin vücuttan atılımının zorlaşması ve Lenfatik dolaşımın yavaşlamasına bağlı olarak selülit oluşumu artar.</li>" +
                        "</ul>" +
                    "</p>",
                subImageUrl = "selulit.jpg"
            });

            listSubCategory.Add(new SubCategoryModel
            {
                subId = 1,
                topReferenceId = 4,
                subTitle = "Kalıcı Makyaj",
                subDesc = 
                    "Permanent make-up yani kalıcı makyaj, uygulamada bazı farklılıklar olsa da aslında" +
                     "bir dövme uygulamasıdır.Bu işlemle boya maddeleri steril ve tek kullanımlık iğneler yardımıyla cildin" +
                     "alt tabakasına zerk edlir. Boya maddeleri doğal maddelerden elde edilir. Katkı maddeleri ve koku içermez." +
                     "Kalıcı makyaj cildi uyuşturan kremler ile anestezi sağlandıktan sonra özel kalıcı makyaj cihazları ile" +
                     "uygulanır.İşlem sırasında hafif bir batma hissi olabilir.Uygulama 2-3 saat arası sürebilir.Yapılan" +
                     "uygulama 1-3 yıl kadar kalıcılık göstermektedir. Bu sürenin sonuna doğru kalıcı makyaj silikleşmeye" +
                     "başlar." +
                     "<p>Kalıcı makyaj bir mikro pigmentasyon tedavisidir. Bu tedavi  çeşitli kozmetik uygulamaların yanısıra " +
                         "kemoterapiye bağlı veya genetik nedenlerle kaşları dökülenlere kaş yapılması, izlerin veya ciltte beyazlama" +
                         "ile giden vitiligo hastalığında kamuflaj amaçlı ve göğüs kanserinden sonra meme ucu renklendirilmesi gibi farklı"+
                         "hastalıkların estetik görüntü bozukluklarında kullanılmaktadır.</p>",

                subImageUrl = "kalici_makyaj.jpg"
            });

            listSubCategory.Add(new SubCategoryModel
            {
                subId = 1,
                topReferenceId = 4,
                subTitle = "Ellerin Gençleştirilmesi",
                subDesc = 
                    "El sıkışırken, birbirimize el sallarken ya da bir konuşma yaparken yüzümüzden sonra"+
                    "vücudumuzda en çok dikkat çeken bölge ellerimizdir.Çoğu zaman yüzümüze verdiğimiz"+
                   " önemi ellerimize vermiyoruz. Oysa yaşımızı en çok gösteren bölgelerden biri de ellerimizdir."+
					"<p>"+
					"Ellerimizi gençleştirirken derinin yüzeyel ve derin bölümlerini birlikte ele almak gerekir."+
                    "Yüzeyel olarak özellikle güneş hasarları, güneş lekelerini tedavi etmek önemlidir.Bunların"+
                    "dışında kırışıklıkları ve hacim kaybına bağlı ellerin üzerinde damar ve tendonların"+
                    "belirginleşmesi ile ortaya çıkan kemikli el yapısını düzeltmek gereklidir."+
					"</p>"+			
                    "<p>"+
			        "Yüzeydeki koyu lekelerin giderilmesinde farklı tedavi seçenekleri vardır.Bunlar arasında"+
                    "kimyasal peelingler, lazer uygulamaları ve kriyoterapi sayılabilir.Bu işlemlerin kış"+
                    "döneminde yapılması uygundur."+
					"</p>"+
                    "<p>"+
                    "Ellerin gençleştirilmesinde dermisdeki kollajeni arttırmak amacıyla hyaluronik asit"+
                    "enjeksiyonları, mezoterapi ve PRP tedavileri uygulanmaktadır.Diğer yandan hacim kaybı"+
                    "olan ellerde dolgu uygulamaları yüz güldürücü sonuçlar vermektedir.Her yıl uygulanacak"+
                   "hyaluronik asit veya kalsiyum hidroksi apatit kristalleri içeren dolgular ellerin genç kalmasını"+
                    "sağlamak için uygun tedavi seçeneklerindendir."+
					"</p>"+
                    "<p>"+
                    "Eller için özel hazırlanmış dermakozmetik kremler ile uygulanan tedaviler desteklenmelidir."+
                    "Gündüz kullanılan kremlerde güneş koruyucu da olması el üzerinde lekelerin oluşmasını"+
                    "önlemede önem taşımaktadır.Gece sürdüğümüz kremler ise antiaging içerikli olmalıdır."+
                    "Ellerde yağ bezleri daha az olduğundan ve ellerimiz su ve sabunla sürekli temas halinde"+
                    "olduğundan lipid bariyerini koruyacak kremler tercih edilmelidir."+
					"</p>",
                subImageUrl = "el_genclestirme.jpg"
            });

            listViewSubCategory.BindingContext = listSubCategory.Where(p => p.topReferenceId == topModel.topId);
        }

        private void onSelectedSubCategory(object sender, SelectedItemChangedEventArgs e)
        {
            ListView listPractice = (ListView)sender;

            if (e.SelectedItem != null)
            {
                var selectedSub = (SubCategoryModel)e.SelectedItem;
                Navigation.PushAsync(new SubCategoryDetailPage(selectedSub));
            }

            listPractice.SelectedItem = null;
        }
    }
}