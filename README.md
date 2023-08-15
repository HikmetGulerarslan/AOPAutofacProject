# Aspect Oriented Programming (AOP) Nedir?

AOP, yazılımın karmaşıklığını azaltmaya, modülariteyi artırmaya yarayan bir yaklaşım biçimidir. Buradaki modülariteden kasıt uygulama süresince sistemin birçok bölümünde kullanılan, fonksiyonel olmayan kodun yani kesişen ilgilerin ufak ufak parçalara ayrılmasıdır (Seperation of Cross Cutting Concerns). Bu sayede uygulama genelinde kullanılacak olan yapıları, sistemden soyutlamış olup enkapsüle de ederek birçok yerde kullanılmasını sağlar. Genel olarak AOP bir sorunu çözmektense var olan sistemin daha güzel bir hale getirilmesini de sağlamaya yardımcı olur.

# Cross Cutting Concerns Nedir?

Cross Cutting Concerns’ün Türkçe anlamı “Kesişen İlgiler" ya da “Çapraz Kesen İlgiler" diye geçmektedir. Cross Cutting Concern denilmesinin sebebi katman bağımsız olması, projenin istenilen yerinde kullanılması ile bulunduğu yerden soyutlanmış olmasından kaynaklanmaktadır.

# Autofac Nedir?

Autofac, .Net tabanlı bir IoC kapsayıcıdır. Sınıflar birbirleriyle etkileşime girdiğinde, boyut ve karmaşıklık olarak büyüdükçe uygulamaların esnek kalmasını sağlayan aralarındaki bağımlılıkları yönetir. Autofac, ASP.NET için en yaygın kullanılan DI/IoC kapsayıcıdır ve .NET Core ile de tamamen uyumludur.

.NET Core, kullanıma hazır yerleşik bir bağımlılık ekleme çerçevesine sahiptir. Varsayılan DI yeterli işlevsellik sağlasa da, onu kullanırken çeşitli sınırlamalar vardır. Autofac'ın çeşitli özellikleri vardır ve belirli durumlarda yerleşik bağımlılık enjeksiyon çerçevesinden daha esnektir, bu da onu iyi bir alternatif haline getirir.
