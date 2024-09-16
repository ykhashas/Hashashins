# Hashashins
MVC mimarisi kullanılarak oluşturmuş olduğum CRM otomasyonu projesidir. Bu projede gelen, giden çağrıları/mesajları görebilirsiniz. Bu çağrılarla ilgili aksiyon alabilir veya çalışanlar arasında çağrı atamaları yapabilirsiniz.
Projenin web tarafı ve masaüstü tarafı olarak ikiye ayrılmakta olup yönetici veya standart giriş yapabilirsiniz. Yetkilendirmeler iki giriş arasında farklıdır. Yeni çağrı ekleme, güncelleme, silme veya görüntüleme
yapılabildiği gibi gelen,giden çağrılar/mesajlar üzerinde filtreleme, raporlama veya istatistik kontrolleri yapabilirsiniz.

# Kullanılan Teknolojiler
- C#
- DevExpress
- MVC Architecture
- SQL
- Json
- Entity Framework Db First
- HTML-CSS-Bootstrap

# GİRİŞ
Çağrı merkezleri ya da diğer bilinen ismiyle müşteri hizmetleri olarak başlıca bir sektör halinde bizlere hizmet veren bir çok kurum veya kuruluş bulunmaktadır. Her çağrı merkezi firması kendi içerisinde müşterisi ile iletişimi sağlayabilmek için programlar kullanmaktadır. Ayrıca firma içerisindeki çalışanların veya aynı sektördeki farklı bir firmaların birbirleri ile olan iletişimini ve iş takibini yapabilmesi içinde programlar kullanılmaktadır. HASHASHINS – CRM Otomasyonu projemizde ele aldığımız ve yapmayı amaçladığımız, müşteri(son kullanıcı) – firma iletişimi değil, firma – firma ve firma içi iletişimi üzerine planlanmıştır. Sektörde programlar CRM otomasyonu olarak tasarlanmakta, planlanmakta ve firmalara sunulmaktadır. CRM (Customer Relationship Management), tam kelime anlamı ise müşteri ilişkileri yönetimidir. Müşteri ilişkileri yönetimi  otomasyonları tam olarak adında da anlattığı üzere çağrı merkezi firmalarının müşteri(son kullanıcı) ile olan ilişkilerini takip edebildiği, düzenli olarak veri kontrolü yapabildiği bir kullanıcı arayüzü sağlamaktadır. Çağrı merkezi sektöründe müşteri her şeydir ve müşteriye dokunabilmek için de veriler üzerinden çıkarımlar yapılması gerekmektedir. Bu verilere ulaşabilecekleri yerler ise yine CRM otomasyonları olacaktır. HASHASHINS projemizde sektörde faaliyet gösteren çalışanların birbirleri ile olan iletişimleri, müşterilerden(son kullanıcılardan) gelen talepler/şikayetler ve aynı sektördeki farklı alt veya üst firmalardan gelen bildiriler takip edilecektir. Projemizin kapsama alanı temelde çağrı merkezi sektöründe faaliyet gösteren idari birimler(mavi yaka, beyaz yaka) için planlanmıştır.

# LİTERATÜR
HASHASHINS - CRM (Müşteri İlişkileri Yönetimi) otomasyonu, işletmelerin müşteri ilişkilerini yönetmek, etkileşimleri izlemek ve optimize etmek için kullanılan bir sistemdir. Bu sistem genellikle yazılım tabanlı olup, müşteri verilerini toplar, saklar, analiz eder ve bu verileri kullanarak işletmelerin müşterileriyle etkileşimini geliştirmesine yardımcı olur. Projemizde daha ön planda olan kısım ise, firmaların son kullanıcı ile olan ilişkilerinden ziyade şirket içi çalışanların ve aynı sektördeki farklı firmaların birbirleri ile olan iletişimi ve ilişkileri üzerine olmaktadır.

HASHASHINS - CRM otomasyonunun temel amaçlarından bazıları şunlardır:

•	Çalışanların Verilerini Yönetme: HASHASHINS - CRM otomasyonu, çalışan iletişimi ile alakalı verileri tek bir merkezi yerde toplar ve organize eder.

•	Şirket İçi Çalışanların Etkileşimini İyileştirme: Bu sistem, şirket içi çalışanların ve aynı sektördeki farklı firmaların birbirleriyle olan etkileşimlerini izler, bu etkileşimleri zamanında ve kişiselleştirilmiş şekilde yönetmeyi sağlar. Bu da şirketin ve çalışanların deneyimini iyileştirir.

•	Çalışanın Sadakatini Artırma: Çalışan sadakatini ve motivasyonunu artırmak, takım çalışmasına teşvik etmek, çalışan memnuniyetini sağlamak açısından önemlidir. HASHASHINS - CRM otomasyonu, çalışan tercihlerini anlayarak kişiselleştirilmiş deneyimler sunmayı ve çalışanların işletmeye bağlılığını artırmayı amaçlar.

HASHASHINS - CRM otomasyon sistemleri, farklı işletme ihtiyaçlarına göre özelleştirilebilir ve genellikle kullanıcı dostu arayüzleriyle kolaylıkla erişilebilir. Bu sistemler, işletmelerin çalışan odaklı stratejiler geliştirmelerine ve çalışan ilişkilerini etkin bir şekilde yönetmelerine yardımcı olur.

# PROJE MODELİNİN VERİLMESİ
Proje tamamlandıktan sonraki ilk müşteri profili olarak küçük işletmeler ve tekil kişiler üzerinden ilerleyip, finansal fizibilite açısından kar getireceği an itibariyle yapılacak proje modeli;
•	Ekip ve Yetkilendirme: Tek bir kişi üzerinden proje yönetimi yerine, belirli bir ekip oluşturulacaktır. Bu ekip, farklı uzmanlık alanlarına sahip bireylerden oluşacak ve teknik destek, güvenlik, veritabanı yönetimi gibi konularda uzmanlık sağlıyor olacaklar.

•	Hizmet Sağlayıcılarla İş Birliği: Veritabanı barındırma hizmeti için ayrılacak bütçe ile güvenilir hizmet sağlayıcılarıyla iş birliği yapılacaktır. Bu sağlayıcılar, teknik destek, veri güvenliği ve KVKK uyumluluğu gibi konularda uzmanlaşmış kişilerden veya kuruluşlardan oluşacaklar.

•	Sözleşme ve Taahhütler: Veritabanı barındırma hizmeti alınacak firmayla yapılan sözleşmelerde, veri güvenliği ve KVKK gerekliliklerine uygunluk için belirli taahhütler sağlanacaktır. Bu taahhütler, müşteri verilerinin korunması, gizliliği ve gerektiğinde geri alınabilir olması gibi konuları içerecektir.

•	Sürekli İyileştirme ve İzleme: Projenin devamı süresince, sürekli olarak yapılan işleri gözden geçirerek iyileştirmeler yapılacaktır. Özellikle teknik destek ve güvenlik konularında düzenli izleme ve denetimler yapılması, olası sorunların önceden tespit edilmesini sağlayacaktır.
Bu stratejiler, projenin teknik destek, güvenlik, veritabanı yönetimi ve bahsedilen gerçekçi kısıtlarla alakalı kritik alanlarda daha sağlam bir yapı oluşturulmasına yardımcı olacaktır.

## Masaüstü Açılış Ekranı UI
![deneme](https://github.com/ykhashas/Hashashins/blob/main/Hashashins_CRM/Hashashins_CRM/bin/Debug/A%C3%A7%C4%B1l%C4%B1%C5%9F%20Ekran%C4%B1.png)
## Masaüstü Giriş Ekranı UI
![deneme](https://github.com/ykhashas/Hashashins/blob/main/Hashashins_CRM/Hashashins_CRM/bin/Debug/Giri%C5%9F%20Ekran%C4%B1.png)
## Web Sayfası Giriş Ekranı UI
![deneme](https://github.com/ykhashas/Hashashins/blob/main/Hashashins_CRM/Hashashins_CRM/bin/Debug/Login%20Page.png)
## Masaüstü Anasayfa UI
![deneme](https://github.com/ykhashas/Hashashins/blob/main/Hashashins_CRM/Hashashins_CRM/bin/Debug/Anasayfa.png)
## Masaüstü Dashboard UI
![deneme](https://github.com/ykhashas/Hashashins/blob/main/Hashashins_CRM/Hashashins_CRM/bin/Debug/Dasboard%20Tasar%C4%B1m%C4%B1.png)
