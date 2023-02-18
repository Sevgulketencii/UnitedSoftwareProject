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

![9s](https://user-images.githubusercontent.com/114435614/219852786-3d2763c8-2320-4616-b1a4-75706fb368bf.png)
![10s](https://user-images.githubusercontent.com/114435614/219852788-9960220b-1513-4bc8-a0ca-d8ac84dd8039.png)
![1s](https://user-images.githubusercontent.com/114435614/219852792-5955ae58-fd4a-4fb6-9c7e-8a8c574363fb.png)
![2s](https://user-images.githubusercontent.com/114435614/219852809-9d1582de-3790-46e5-a4e0-cd26ab5a70be.png)
![3s](https://user-images.githubusercontent.com/114435614/219852811-ff0e65aa-fab3-4b72-9115-aa8743bf579b.png)
![4s](https://user-images.githubusercontent.com/114435614/219852812-aa186a01-183e-4ded-b0a4-0312996f7d50.png)
![5s](https://user-images.githubusercontent.com/114435614/219852815-af38f982-f3ae-4dcb-98ed-64012a75ce2d.png)
![6ss](https://user-images.githubusercontent.com/114435614/219852818-0540e0ae-b767-4396-b1fb-245182f0d35d.png)
![7s](https://user-images.githubusercontent.com/114435614/219852819-c947f48d-00f6-4386-b333-83a72ab71831.png)
![8s](https://user-images.githubusercontent.com/114435614/219852820-c202df12-b318-4c1f-a2e4-316b4d4006c8.png)
