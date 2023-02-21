# UnitedSoftwareProject

United United Yazılım Teknolojilerinin işe alım için iletilen projenin isterleri aşağıda belirtilmiştir.

Bu sitede kullanıcının yöneteceği notlar bulunmalı ve bu notlar ağaç yapısı şeklinde iç içe yapıda olmalıdır.
Kullanıcı bir not altına yeni notlar ekleyebilmeli ve silebilmelidir.
Eklenen veya silinen notlar API ile veritabanında saklanmalıdır.
Görsel anlamda bir beklentimiz yok, notlar iç içe görünsün yeterlidir.
Mssql, Mysql vs herhangi bir veritabanı kullanılabilir.

Proje N katmanlı mimari ile oluşturulmuştur. 5 katman bulunmaktadır bu katmanlar sırası ile 
1-EntityLayer (EntityLayer katmanı bizim code first yaklaşımı ile oluşturduğumuz db'nin tablolarını yani classlar'ını ve bu tabloların sütunlarını yani property'lerini tutmaktadır)
2-DataAccesLayer (DataAccesLayer katmanı bizim Crud işlemlerimizi , db connection string'i barındıran class'ımızı , migrationlarımızı barındırmaktadır)
3-BusinessLayer (BusinessLayer katmanı ise UserUI ile DataAccesLayer katmanlarımız arasında köprü vazifesi görmektedir)
4-UserUI - Presentation (UserUI katmanı client'ın görüceği tüm içerikleri barındıran katmandır. Model-view-controller yapıları içerisinde bulunur)
5-Api (Api katmanı sitede oluşturulan Post (Not kategorileri) ya da FoodPost(Kategori altı notlar) içerisinde tutan db'ye ve http metodlarına sahiptir. Rest Api kullanılmıştır.

Client siteye istek attığında oluşturulan kural ile kullanıcının kimliğini doğrulaması istenmektedir. Kullanıcı url üzerinden veya başka bir yol ile site içeriğine ulaşamamaktadır.
Kimliği doğrulanmış kullanıcıya ait Post ve FoodPost'lar responce edilmektedir.


![1b](https://user-images.githubusercontent.com/114435614/220462630-df7fccb8-0fca-4f11-88cb-608bfc88a375.png)
![1a](https://user-images.githubusercontent.com/114435614/220462172-972d34c0-5f9e-4999-9345-8354ce106827.png)
![2a](https://user-images.githubusercontent.com/114435614/220462174-f57c28f9-e730-4aa8-acf4-0ae6f3e1e476.png)
![3a](https://user-images.githubusercontent.com/114435614/220462176-085c4327-6e02-465a-b565-b20add291b3e.png)
![4a](https://user-images.githubusercontent.com/114435614/220462180-6cd34a2c-91d2-4357-a162-d6dd90ef498c.png)
![5a](https://user-images.githubusercontent.com/114435614/220462183-5be8ef79-7942-4a07-9490-5e0dfa55a7a4.png)
![7a](https://user-images.githubusercontent.com/114435614/220462196-9bf812a1-919d-4ecc-b444-d752322de209.png)
![8a](https://user-images.githubusercontent.com/114435614/220462203-adf9943d-2345-4acb-a8d4-daf1afb29edd.png)
![9a](https://user-images.githubusercontent.com/114435614/220462206-5c8b4cad-f411-4923-a250-77b855e725a9.png)
![10a](https://user-images.githubusercontent.com/114435614/220462242-80ed893d-3d43-4e52-8cd6-bdc195f906eb.png)
![11a](https://user-images.githubusercontent.com/114435614/220462247-6a72851e-a254-4edd-a2ae-b27af72c99bf.png)
![12a](https://user-images.githubusercontent.com/114435614/220462257-5b0fe99e-ebf6-42f5-bfa1-68e576ac7c99.png)
