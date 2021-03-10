USE [demo-rest-api]
GO

/****** Object:  Table [dbo].[Results]    Script Date: 09/03/2021 07:45:27 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Results](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[number_in_1] [int] NOT NULL,
	[number_in_2] [int] NOT NULL,
	[func] [varchar](max) NOT NULL,
	[number_out] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


