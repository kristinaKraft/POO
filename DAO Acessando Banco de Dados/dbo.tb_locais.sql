CREATE TABLE [dbo].[tb_locais] (
    [Id]     INT        IDENTITY (1, 1) NOT NULL,
    [nome]   NCHAR (40) NOT NULL,
    [rua]    NCHAR (40) NOT NULL,
    [numero] NCHAR (4)  NULL,
    [cidade] NCHAR (30) NULL,
    [uf]     NCHAR (2)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

