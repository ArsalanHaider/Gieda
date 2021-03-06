USE [master]
GO
/****** Object:  Database [gieda]    Script Date: 11/21/2019 2:12:55 AM ******/
CREATE DATABASE [gieda]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gieda', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\gieda.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'gieda_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\gieda_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [gieda] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gieda].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gieda] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gieda] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gieda] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gieda] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gieda] SET ARITHABORT OFF 
GO
ALTER DATABASE [gieda] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [gieda] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gieda] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gieda] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gieda] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gieda] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gieda] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gieda] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gieda] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gieda] SET  ENABLE_BROKER 
GO
ALTER DATABASE [gieda] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gieda] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gieda] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gieda] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gieda] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gieda] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [gieda] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gieda] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [gieda] SET  MULTI_USER 
GO
ALTER DATABASE [gieda] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gieda] SET DB_CHAINING OFF 
GO
ALTER DATABASE [gieda] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [gieda] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [gieda] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [gieda] SET QUERY_STORE = OFF
GO
USE [gieda]
GO
/****** Object:  Table [dbo].[allotee_plots]    Script Date: 11/21/2019 2:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[allotee_plots](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[allottee_id] [int] NOT NULL,
	[plot_id] [int] NOT NULL,
 CONSTRAINT [PK_allotee_plots] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[allottee_documents]    Script Date: 11/21/2019 2:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[allottee_documents](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](191) NOT NULL,
	[document] [text] NOT NULL,
	[allotee_id] [int] NOT NULL,
	[created_at] [datetime] NOT NULL,
	[updated_at] [datetime] NOT NULL,
 CONSTRAINT [PK_allottee_documents] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[allottee_payments]    Script Date: 11/21/2019 2:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[allottee_payments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NOT NULL,
	[description] [varchar](191) NOT NULL,
	[due_amount] [int] NOT NULL,
	[due_date] [date] NOT NULL,
	[allottee_id] [int] NOT NULL,
	[amount] [int] NOT NULL,
	[paid_on] [date] NOT NULL,
	[surcharge] [int] NOT NULL,
	[total_amount] [int] NOT NULL,
	[created_at] [datetime] NOT NULL,
	[updated_at] [datetime] NOT NULL,
 CONSTRAINT [PK_allottee_payments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[allottees]    Script Date: 11/21/2019 2:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[allottees](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[father_name] [varchar](50) NOT NULL,
	[address] [varchar](50) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[province] [varchar](50) NULL,
	[domicile] [varchar](50) NOT NULL,
	[pds_number] [varchar](50) NOT NULL,
	[nic] [bigint] NOT NULL,
	[af_number] [varchar](50) NOT NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
	[picture] [text] NULL,
 CONSTRAINT [PK_allottees] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[data_update]    Script Date: 11/21/2019 2:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[data_update](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
 CONSTRAINT [PK_data_update] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employees]    Script Date: 11/21/2019 2:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employees](
	[id] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[father_name] [varchar](50) NOT NULL,
	[address] [varchar](191) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[province] [varchar](50) NOT NULL,
	[employee_id] [varchar](50) NULL,
	[contact_number] [varchar](50) NOT NULL,
	[created_at] [datetime] NOT NULL,
	[updated_at] [datetime] NOT NULL,
 CONSTRAINT [PK_employees] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[installment_payments]    Script Date: 11/21/2019 2:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[installment_payments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[allottee_id] [int] NOT NULL,
	[installment_id] [int] NOT NULL,
	[title] [varchar](191) NOT NULL,
	[due_amount] [int] NOT NULL,
	[due_date] [date] NOT NULL,
	[amount] [int] NOT NULL,
	[surcharge] [int] NOT NULL,
	[paid_on] [date] NOT NULL,
	[total_amount] [int] NOT NULL,
	[created_at] [datetime] NOT NULL,
	[updated_at] [datetime] NOT NULL,
 CONSTRAINT [PK_installment_payments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[installments]    Script Date: 11/21/2019 2:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[installments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NOT NULL,
	[amount] [varchar](50) NOT NULL,
	[due_date] [varchar](50) NOT NULL,
	[created_at] [datetime] NOT NULL,
	[updated_at] [datetime] NOT NULL,
	[plot_id] [int] NOT NULL,
 CONSTRAINT [PK_installments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[other_charges]    Script Date: 11/21/2019 2:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[other_charges](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NULL,
	[description] [varchar](191) NULL,
	[amount] [int] NULL,
	[plot_id] [int] NULL,
 CONSTRAINT [PK_other_charges] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permissions]    Script Date: 11/21/2019 2:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permissions](
	[id] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[roles_id] [int] NOT NULL,
 CONSTRAINT [PK_permissions] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phases]    Script Date: 11/21/2019 2:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phases](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[title] [varchar](191) NOT NULL,
	[description] [text] NOT NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_phases] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[plots]    Script Date: 11/21/2019 2:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[plots](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [text] NULL,
	[size] [varchar](50) NULL,
	[description] [varchar](50) NULL,
	[down_payment] [int] NULL,
	[form_fee] [varchar](50) NULL,
	[total_price] [varchar](50) NULL,
	[installments] [varchar](50) NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
	[quantity] [int] NULL,
	[phase_id] [int] NULL,
 CONSTRAINT [PK_plots] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 11/21/2019 2:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[id] [int] NOT NULL,
	[name] [varchar](50) NULL,
 CONSTRAINT [PK_roles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[surcharges]    Script Date: 11/21/2019 2:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[surcharges](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](191) NOT NULL,
	[amount] [int] NOT NULL,
	[paid_on] [date] NOT NULL,
	[due_amount] [int] NOT NULL,
	[due_date] [date] NOT NULL,
 CONSTRAINT [PK_surcharges] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserLoginTimeLog]    Script Date: 11/21/2019 2:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLoginTimeLog](
	[userId] [int] NOT NULL,
	[userLoginTime] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 11/21/2019 2:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[roleId] [int] NOT NULL,
	[role] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 11/21/2019 2:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[email] [varchar](191) NOT NULL,
	[password] [text] NOT NULL,
	[roles_id] [int] NOT NULL,
	[emp_id] [int] NOT NULL,
	[created_at] [datetime] NOT NULL,
	[updated_at] [datetime] NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Userss]    Script Date: 11/21/2019 2:12:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Userss](
	[userId] [int] NOT NULL,
	[userName] [varchar](50) NOT NULL,
	[userPassword] [varchar](50) NOT NULL,
	[roleId] [int] NULL,
	[name] [varchar](max) NULL,
	[cnic] [varchar](50) NULL,
	[contact] [varchar](50) NULL,
	[email] [varchar](max) NULL,
	[userProfileCreate] [datetime] NULL,
	[address] [varchar](max) NULL,
 CONSTRAINT [PK_Userss] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[allottee_payments] ADD  CONSTRAINT [DF_allottee_payments_created_at]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[allottee_payments] ADD  CONSTRAINT [DF_allottee_payments_updated_at]  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[allotee_plots]  WITH CHECK ADD  CONSTRAINT [FK_allotee_plots_allottees] FOREIGN KEY([allottee_id])
REFERENCES [dbo].[allottees] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[allotee_plots] CHECK CONSTRAINT [FK_allotee_plots_allottees]
GO
ALTER TABLE [dbo].[allotee_plots]  WITH CHECK ADD  CONSTRAINT [FK_allotee_plots_plots] FOREIGN KEY([plot_id])
REFERENCES [dbo].[plots] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[allotee_plots] CHECK CONSTRAINT [FK_allotee_plots_plots]
GO
ALTER TABLE [dbo].[allottee_documents]  WITH CHECK ADD  CONSTRAINT [FK_allottee_documents_allottees] FOREIGN KEY([allotee_id])
REFERENCES [dbo].[allottees] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[allottee_documents] CHECK CONSTRAINT [FK_allottee_documents_allottees]
GO
ALTER TABLE [dbo].[allottee_payments]  WITH CHECK ADD  CONSTRAINT [FK_allottee_payments_allottees] FOREIGN KEY([allottee_id])
REFERENCES [dbo].[allottees] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[allottee_payments] CHECK CONSTRAINT [FK_allottee_payments_allottees]
GO
ALTER TABLE [dbo].[installment_payments]  WITH CHECK ADD  CONSTRAINT [FK_installment_payments_allottees] FOREIGN KEY([allottee_id])
REFERENCES [dbo].[allottees] ([id])
GO
ALTER TABLE [dbo].[installment_payments] CHECK CONSTRAINT [FK_installment_payments_allottees]
GO
ALTER TABLE [dbo].[installments]  WITH CHECK ADD  CONSTRAINT [FK_installments_plots] FOREIGN KEY([plot_id])
REFERENCES [dbo].[plots] ([id])
GO
ALTER TABLE [dbo].[installments] CHECK CONSTRAINT [FK_installments_plots]
GO
ALTER TABLE [dbo].[other_charges]  WITH CHECK ADD  CONSTRAINT [FK_other_charges_plots] FOREIGN KEY([plot_id])
REFERENCES [dbo].[plots] ([id])
GO
ALTER TABLE [dbo].[other_charges] CHECK CONSTRAINT [FK_other_charges_plots]
GO
ALTER TABLE [dbo].[permissions]  WITH CHECK ADD  CONSTRAINT [FK_permissions_roles] FOREIGN KEY([roles_id])
REFERENCES [dbo].[roles] ([id])
GO
ALTER TABLE [dbo].[permissions] CHECK CONSTRAINT [FK_permissions_roles]
GO
ALTER TABLE [dbo].[plots]  WITH CHECK ADD  CONSTRAINT [FK_plots_phases] FOREIGN KEY([phase_id])
REFERENCES [dbo].[phases] ([id])
GO
ALTER TABLE [dbo].[plots] CHECK CONSTRAINT [FK_plots_phases]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_users_employees] FOREIGN KEY([emp_id])
REFERENCES [dbo].[employees] ([id])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_employees]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_users_roles] FOREIGN KEY([roles_id])
REFERENCES [dbo].[roles] ([id])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_roles]
GO
USE [master]
GO
ALTER DATABASE [gieda] SET  READ_WRITE 
GO
