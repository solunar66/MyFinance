SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Table_Comment]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Table_Comment](
  [id] [int] IDENTITY(1,1) NOT NULL,
	[date] [datetime] NOT NULL,
	[comment] [nvarchar](max) NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Table_Company]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Table_Company](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[contact] [nvarchar](50) NULL,
	[telephone] [nvarchar](50) NULL,
	[invests] [nvarchar](max) NULL,
	[comment] [nvarchar](max) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Table_Invest]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Table_Invest](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[partner_id] [int] NOT NULL,
	[project_id] [int] NOT NULL,
	[partner_volume] [numeric](18, 0) NOT NULL,
	[partner_start_date] [datetime] NOT NULL,
	[partner_end_date] [datetime] NOT NULL,
	[comment] [nvarchar](max) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Table_Partner]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Table_Partner](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[volume] [numeric](18, 0) NOT NULL,
	[start_date] [datetime] NOT NULL,
	[end_date] [datetime] NOT NULL,
	[yield] [float] NOT NULL,
	[settle_type] [int] NOT NULL,
	[settle_date] [int] NOT NULL,
	[comment] [nvarchar](max) NULL,
 CONSTRAINT [PK_Table_Partner] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Table_Project]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Table_Project](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[company] [int] NOT NULL,
	[contact] [nvarchar](50) NULL,
	[telephone] [nvarchar](50) NULL,
	[start_date] [datetime] NOT NULL,
	[end_date] [datetime] NOT NULL,
	[settle_date] [int] NOT NULL,
	[settle_type] [int] NOT NULL,
	[yield] [float] NOT NULL,
	[comment] [nvarchar](max) NULL
) ON [PRIMARY]
END
