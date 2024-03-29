/****** Object:  Database [DbTesteApp]    Script Date: 31/08/2019 12:36:53 ******/
create database  [DbTesteApp]
go
use  [DbTesteApp]
GO
/****** Object:  Table [dbo].[TbCliente]    Script Date: 31/08/2019 12:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TbCliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NULL,
	[UF] [varchar](2) NULL,
	[Celular] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TbFinanciamento]    Script Date: 31/08/2019 12:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TbFinanciamento](
	[IdFinanciamento] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[TipoFinanciamento] [varchar](50) NOT NULL,
	[ValorTotal] [int] NULL,
	[DataVencimento] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFinanciamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TbParcela]    Script Date: 31/08/2019 12:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbParcela](
	[IdParcela] [int] NOT NULL,
	[IdFinanciamento] [int] NOT NULL,
	[NumParcelas] [int] NULL,
	[ValorParcela] [decimal](18, 0) NULL,
	[DataVencmento] [datetime] NULL,
	[DataPagamento] [datetime] NULL,
 CONSTRAINT [PK_TbParcela] PRIMARY KEY CLUSTERED 
(
	[IdParcela] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [DbTesteApp] SET  READ_WRITE 
GO
