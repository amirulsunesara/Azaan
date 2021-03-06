USE [StudentManagementSystem]
GO
/****** Object:  Table [dbo].[administrator]    Script Date: 11/27/2015 05:49:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[administrator](
	[admin_id] [int] NOT NULL,
	[admin_password] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[admin_fname] [varchar](50) NOT NULL,
	[admin_lname] [varchar](50) NOT NULL,
 CONSTRAINT [PK_administrator] PRIMARY KEY CLUSTERED 
(
	[admin_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[student]    Script Date: 11/27/2015 05:49:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[student](
	[student_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](50) NOT NULL,
	[last_name] [varchar](50) NOT NULL,
	[telephone] [varchar](50) NULL,
	[cell_no] [varchar](50) NULL,
	[address] [varchar](100) NULL,
	[password] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_student] PRIMARY KEY CLUSTERED 
(
	[student_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Registration]    Script Date: 11/27/2015 05:49:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Registration](
	[student_id] [int] NOT NULL,
	[course_id] [int] NOT NULL,
	[student_name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[student_id] ASC,
	[course_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[message]    Script Date: 11/27/2015 05:49:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[message](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[sender] [varchar](50) NOT NULL,
	[reciever] [varchar](50) NOT NULL,
	[message] [varchar](500) NOT NULL,
	[subject] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[marks]    Script Date: 11/27/2015 05:49:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[marks](
	[course_id] [int] NOT NULL,
	[student_id] [int] NOT NULL,
	[marks] [int] NOT NULL,
 CONSTRAINT [PK_marks] PRIMARY KEY CLUSTERED 
(
	[course_id] ASC,
	[student_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lectures]    Script Date: 11/27/2015 05:49:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lectures](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LectureName] [varchar](50) NOT NULL,
	[LectureDescription] [varchar](50) NOT NULL,
	[PictureUri] [varchar](50) NOT NULL,
	[course_id] [varchar](50) NOT NULL,
	[instructor_name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[instructor]    Script Date: 11/27/2015 05:49:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[instructor](
	[instructor_id] [int] IDENTITY(1,1) NOT NULL,
	[instructor_fname] [varchar](50) NOT NULL,
	[instructor_lname] [varchar](50) NOT NULL,
	[instructor_cellno] [varchar](50) NOT NULL,
	[instructor_email] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[telephone] [varchar](50) NOT NULL,
	[address] [varchar](50) NOT NULL,
 CONSTRAINT [PK_instructor] PRIMARY KEY CLUSTERED 
(
	[instructor_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[feedback]    Script Date: 11/27/2015 05:49:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[feedback](
	[Student_id] [int] NOT NULL,
	[instructor] [int] NOT NULL,
	[venue] [int] NOT NULL,
	[volunteer] [int] NOT NULL,
	[hospitality] [int] NOT NULL,
	[course] [int] NOT NULL,
	[registration] [int] NOT NULL,
	[atmosphere] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Student_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[course]    Script Date: 11/27/2015 05:49:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[course](
	[course_id] [int] IDENTITY(1,1) NOT NULL,
	[course_name] [varchar](50) NOT NULL,
	[instructor_id2] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[course_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_Course]    Script Date: 11/27/2015 05:49:23 ******/
ALTER TABLE [dbo].[course]  WITH NOCHECK ADD  CONSTRAINT [FK_Course] FOREIGN KEY([instructor_id2])
REFERENCES [dbo].[instructor] ([instructor_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[course] CHECK CONSTRAINT [FK_Course]
GO
