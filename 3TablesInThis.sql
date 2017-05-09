USE [CourseGrading]
GO

/****** Object:  Table [dbo].[Student]    Script Date: 21-Apr-17 1:00:49 AM ******/

--||||||||||||||||||||||||||||  Student Table  |||||||||||||||||||||||||||||||||||||
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Student](
	[Student ID] [int] IDENTITY(1,1) NOT NULL,
	[First Name] [varchar](50) NOT NULL,
	[Last Name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Student ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UC_Student] UNIQUE NONCLUSTERED 
(
	[First Name] ASC,
	[Last Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

--||||||||||||||||||||||||||||  Assessment Table  |||||||||||||||||||||||||||||||||||||

/****** Object:  Table [dbo].[Assessment]    Script Date: 21-Apr-17 12:59:42 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Assessment](
	[Assessment_Id] [int] IDENTITY(1,1) NOT NULL,
	[Assessment Type] [varchar](50) NOT NULL,
	[Date] [varchar](50) NOT NULL,
	[Maximum Marks] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Assessment_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

--||||||||||||||||||||||||||||  Student_Assessment Table  |||||||||||||||||||||||||||||||||||||
/****** Object:  Table [dbo].[Student_Assessment]    Script Date: 21-Apr-17 1:08:32 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Student_Assessment](
	[Student ID] [int] NOT NULL,
	[Assessment ID] [int] NOT NULL,
	[Marks] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Student ID] ASC,
	[Assessment ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Student_Assessment]  WITH CHECK ADD  CONSTRAINT [FK_Student_Assessment_ToTable] FOREIGN KEY([Student ID])
REFERENCES [dbo].[Student] ([Student ID])
GO

ALTER TABLE [dbo].[Student_Assessment] CHECK CONSTRAINT [FK_Student_Assessment_ToTable]
GO

ALTER TABLE [dbo].[Student_Assessment]  WITH CHECK ADD  CONSTRAINT [FK_Student_Assessment_ToTable_1] FOREIGN KEY([Assessment ID])
REFERENCES [dbo].[Assessment] ([Assessment_Id])
GO

ALTER TABLE [dbo].[Student_Assessment] CHECK CONSTRAINT [FK_Student_Assessment_ToTable_1]
GO

