   Create proc Kategori_Delete 
   @Id int 
   as 
   Delete from Kategori  where Id = @Id

   go 

   CREATE PROCEDURE Kategori_İnsert
 @Adı nvarchar(150)
  AS
  INSERT INTO Kategori (Adı) Values (@Adı)

  go 

  	Create proc Kategori_Select
	@Id int 
	As select * from Kategori T1 with(Nolock) where T1.Id = @Id

	go 

	
	Create proc Kategori_SelectList 
	As 
	select * from Kategori with(nolock)

	go 

	  Create proc Kategori_Update
   @Id int,
   @Adı nvarchar(100)
   As 
   Update Kategori Set Adı = @Adı Where Id = @Id

   go 

    Create proc Kitap_Delete 
 @Id int 
 As 
 Delete from Kitap where Id = @Id

 go 

 CREATE PROC Kitap_Insert
@Adi NVARCHAR(150),
@Yazar NVARCHAR(150),
@Sayfasayisi SMALLINT,
@Kategoriİd INT
AS
INSERT INTO Kitap(Adi, Yazar, Sayfasayisi,Kategoriİd)
			VALUES (@Adi, @Yazar, @Sayfasayisi,@Kategoriİd)

			go 

			 
 CREATE proc Kitap_Select 
 
 As 
  Select * from  Kitap T1 with(nolock)

  go

     CREATE proc Kitap_SelectList 

   As 
   Select * from Kitap with(nolock)

   go 

   			CREATE PROC Kitap_Update
@Id INT,
@Adi NVARCHAR(150),
@Yazar NVARCHAR(150),
@Sayfasayisi SMALLINT,
@Kategoriİd INT
AS
UPDATE Kitap SET Adi = @Adi,
				 Yazar = @Yazar,
				 Sayfasayisi = @Sayfasayisi,
				 Kategoriİd = @Kategoriİd
			    
WHERE Id = @Id
