create database summer22net
USE [summer22Net]
GO
/****** Object:  Table [dbo].[tbl_contact]    Script Date: 09/29/2021 14:34:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_contact](
	[eid] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[mobile] [varchar](50) NULL,
	[msg] [varchar](max) NULL,
	[EDT] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[eid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Table_registration]    Script Date: 09/29/2021 14:34:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Table_registration](
	[name] [varchar](50) NULL,
	[email] [varchar](50) NOT NULL,
	[password] [varchar](50) NULL,
	[mobile] [varchar](50) NULL,
	[country] [varchar](50) NULL,
	[picture] [varchar](50) NULL,
	[RDT] [varchar](50) NULL,
 CONSTRAINT [PK_Table_registration] PRIMARY KEY CLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Table_login]    Script Date: 09/29/2021 14:34:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Table_login](
	[userid] [varchar](50) NULL,
	[password] [varchar](50) NOT NULL,
	[utype] [varchar](50) NULL,
	[Ldt] [varchar](50) NULL,
 CONSTRAINT [PK_Table_login] PRIMARY KEY CLUSTERED 
(
	[password] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
