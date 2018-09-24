CREATE TABLE [dbo].[Kategori] (
    [Id]  INT            IDENTITY (1, 1) NOT NULL,
    [Adı] NVARCHAR (150) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);



go 


CREATE TABLE [dbo].[Kitap] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Adi]         NVARCHAR (150) NULL,
    [Yazar]       NVARCHAR (150) NULL,
    [Sayfasayisi] SMALLINT       NULL,
    [Kategoriİd]  INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Kitap_Kategori] FOREIGN KEY ([Kategoriİd]) REFERENCES [dbo].[Kategori] ([Id])
);

