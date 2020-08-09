/****** Object:  Table [dbo].[Profiles]    Script Date: 8/8/2020 11:56:40 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Profiles](
	[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[MiddleName] [varchar](50) NULL,
	[LastName] [varchar](50) NOT NULL,
	[Sex] [char](1) NULL,
	[Dob] [date] NOT NULL,
	[Phone] [int] NULL,
	[Email] [varchar](50) NOT NULL,
	[Department] [varchar](50) NULL,
	[UserPicureUrl] [varchar](50) NULL,
	[Age] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


