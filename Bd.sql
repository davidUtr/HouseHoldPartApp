USE [HouseholdPart]
GO
/****** Object:  Table [dbo].[DocumentEmployee]    Script Date: 24.06.2023 12:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentEmployee](
	[DocumentId] [int] NOT NULL,
	[EmployeeId] [int] NULL,
	[DocumentName] [nvarchar](255) NULL,
	[Documents] [nvarchar](max) NULL,
 CONSTRAINT [PK_DocumentEmployee] PRIMARY KEY CLUSTERED 
(
	[DocumentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 24.06.2023 12:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[NameEmployee] [nvarchar](255) NOT NULL,
	[SurnameEmployee] [nvarchar](255) NOT NULL,
	[IdPost] [int] NULL,
	[SerialPasportEmployee] [int] NULL,
	[NumberPasportEmployee] [int] NULL,
	[Contact] [nvarchar](18) NOT NULL,
	[Address] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipment]    Script Date: 24.06.2023 12:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipment](
	[EquipmentId] [int] IDENTITY(1,1) NOT NULL,
	[NameEquipment] [nvarchar](255) NOT NULL,
	[Count] [int] NOT NULL,
	[PurchaseDate] [date] NULL,
	[Cost] [decimal](10, 2) NULL,
	[IdFacilities] [int] NULL,
	[IdSuppliers] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EquipmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facilities]    Script Date: 24.06.2023 12:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facilities](
	[FacilitiesId] [int] IDENTITY(1,1) NOT NULL,
	[NameFacilities] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FacilitiesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Post]    Script Date: 24.06.2023 12:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Post](
	[PostId] [int] IDENTITY(1,1) NOT NULL,
	[PostName] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[PostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScheduleEmployee]    Script Date: 24.06.2023 12:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScheduleEmployee](
	[ScheduleId] [int] IDENTITY(1,1) NOT NULL,
	[IdEmployee] [int] NULL,
	[Date] [date] NULL,
	[TimeStart] [time](7) NULL,
	[TimeEnd] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[ScheduleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 24.06.2023 12:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierId] [int] IDENTITY(1,1) NOT NULL,
	[NameSupplier] [nvarchar](255) NOT NULL,
	[Contact] [nvarchar](255) NOT NULL,
	[Comments] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 24.06.2023 12:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FullNameUser] [nvarchar](255) NOT NULL,
	[Login] [nvarchar](255) NOT NULL,
	[Password] [char](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DocumentEmployee] ([DocumentId], [EmployeeId], [DocumentName], [Documents]) VALUES (1, 3, N'Фото паспорта', N'image2.jpg')
INSERT [dbo].[DocumentEmployee] ([DocumentId], [EmployeeId], [DocumentName], [Documents]) VALUES (2, 1, N'Фото сотрудника', N'Image1.jpg')
INSERT [dbo].[DocumentEmployee] ([DocumentId], [EmployeeId], [DocumentName], [Documents]) VALUES (4, 6, N'Дипломная работа', N'Диплом Даша.docx')
INSERT [dbo].[DocumentEmployee] ([DocumentId], [EmployeeId], [DocumentName], [Documents]) VALUES (5, 2, N'Резюме сотрудника', N'Снимок экрана 2023-06-22 170328.png')
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmployeeId], [NameEmployee], [SurnameEmployee], [IdPost], [SerialPasportEmployee], [NumberPasportEmployee], [Contact], [Address]) VALUES (1, N'Иван', N'Иванов', 1, 1234, 567890, N'+7(900) 123 45 67', N'г.Майкоп ул.Кужорская 32')
INSERT [dbo].[Employee] ([EmployeeId], [NameEmployee], [SurnameEmployee], [IdPost], [SerialPasportEmployee], [NumberPasportEmployee], [Contact], [Address]) VALUES (2, N'Петр', N'Петров', 2, 4321, 98765, N'+7(900) 111 22 33', N'г.Майкоп ул.Коммунаров 10')
INSERT [dbo].[Employee] ([EmployeeId], [NameEmployee], [SurnameEmployee], [IdPost], [SerialPasportEmployee], [NumberPasportEmployee], [Contact], [Address]) VALUES (3, N'Ананд', N'Амкар', 2, 5678, 123456, N'+7(900) 999 88 77', N'г.Майкоп ул.Комсомольская 100')
INSERT [dbo].[Employee] ([EmployeeId], [NameEmployee], [SurnameEmployee], [IdPost], [SerialPasportEmployee], [NumberPasportEmployee], [Contact], [Address]) VALUES (6, N'Дарья', N'Гелашвили', 1, 4324, 43243, N'+7(918) 324 32 54', N'Г.Майкоп Ул.Кирпичная 21')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Equipment] ON 

INSERT [dbo].[Equipment] ([EquipmentId], [NameEquipment], [Count], [PurchaseDate], [Cost], [IdFacilities], [IdSuppliers]) VALUES (1, N'Холодильник', 5, CAST(N'2020-01-01' AS Date), CAST(25000.00 AS Decimal(10, 2)), 1, 1)
INSERT [dbo].[Equipment] ([EquipmentId], [NameEquipment], [Count], [PurchaseDate], [Cost], [IdFacilities], [IdSuppliers]) VALUES (2, N'Доска объявлений', 2, CAST(N'2021-02-15' AS Date), CAST(5000.00 AS Decimal(10, 2)), 2, 1)
INSERT [dbo].[Equipment] ([EquipmentId], [NameEquipment], [Count], [PurchaseDate], [Cost], [IdFacilities], [IdSuppliers]) VALUES (3, N'Стол', 3, CAST(N'2019-05-14' AS Date), CAST(15000.00 AS Decimal(10, 2)), 2, 1)
INSERT [dbo].[Equipment] ([EquipmentId], [NameEquipment], [Count], [PurchaseDate], [Cost], [IdFacilities], [IdSuppliers]) VALUES (4, N'Стул', 6, CAST(N'2018-08-20' AS Date), CAST(6000.00 AS Decimal(10, 2)), 2, 2)
INSERT [dbo].[Equipment] ([EquipmentId], [NameEquipment], [Count], [PurchaseDate], [Cost], [IdFacilities], [IdSuppliers]) VALUES (6, N'Блокнот', 300, CAST(N'2023-06-22' AS Date), CAST(25000.00 AS Decimal(10, 2)), 4, 1)
INSERT [dbo].[Equipment] ([EquipmentId], [NameEquipment], [Count], [PurchaseDate], [Cost], [IdFacilities], [IdSuppliers]) VALUES (7, N'Железная дверь', 1, CAST(N'2023-06-23' AS Date), CAST(7500.00 AS Decimal(10, 2)), 4, 2)
SET IDENTITY_INSERT [dbo].[Equipment] OFF
GO
SET IDENTITY_INSERT [dbo].[Facilities] ON 

INSERT [dbo].[Facilities] ([FacilitiesId], [NameFacilities]) VALUES (1, N'Кухня')
INSERT [dbo].[Facilities] ([FacilitiesId], [NameFacilities]) VALUES (2, N'Кабинет воспитателя')
INSERT [dbo].[Facilities] ([FacilitiesId], [NameFacilities]) VALUES (3, N'Кабинет директора')
INSERT [dbo].[Facilities] ([FacilitiesId], [NameFacilities]) VALUES (4, N'Склад')
SET IDENTITY_INSERT [dbo].[Facilities] OFF
GO
SET IDENTITY_INSERT [dbo].[Post] ON 

INSERT [dbo].[Post] ([PostId], [PostName]) VALUES (1, N'Воспитатель')
INSERT [dbo].[Post] ([PostId], [PostName]) VALUES (2, N'Повар')
INSERT [dbo].[Post] ([PostId], [PostName]) VALUES (3, N'Уборщик')
SET IDENTITY_INSERT [dbo].[Post] OFF
GO
SET IDENTITY_INSERT [dbo].[ScheduleEmployee] ON 

INSERT [dbo].[ScheduleEmployee] ([ScheduleId], [IdEmployee], [Date], [TimeStart], [TimeEnd]) VALUES (1, 1, CAST(N'2023-05-30' AS Date), CAST(N'10:00:00' AS Time), CAST(N'18:00:00' AS Time))
INSERT [dbo].[ScheduleEmployee] ([ScheduleId], [IdEmployee], [Date], [TimeStart], [TimeEnd]) VALUES (2, 2, CAST(N'2023-05-31' AS Date), CAST(N'08:00:00' AS Time), CAST(N'15:00:00' AS Time))
INSERT [dbo].[ScheduleEmployee] ([ScheduleId], [IdEmployee], [Date], [TimeStart], [TimeEnd]) VALUES (5, 3, CAST(N'2023-06-09' AS Date), CAST(N'09:00:00' AS Time), CAST(N'00:00:00' AS Time))
INSERT [dbo].[ScheduleEmployee] ([ScheduleId], [IdEmployee], [Date], [TimeStart], [TimeEnd]) VALUES (6, 1, CAST(N'2023-06-09' AS Date), CAST(N'10:00:00' AS Time), CAST(N'19:00:00' AS Time))
SET IDENTITY_INSERT [dbo].[ScheduleEmployee] OFF
GO
SET IDENTITY_INSERT [dbo].[Suppliers] ON 

INSERT [dbo].[Suppliers] ([SupplierId], [NameSupplier], [Contact], [Comments]) VALUES (1, N'ООО Рога и копыта', N'+7(900) 555 33 33', N'Оптовый поставщик продуктов')
INSERT [dbo].[Suppliers] ([SupplierId], [NameSupplier], [Contact], [Comments]) VALUES (2, N'ООО Стройстрой', N'+7(900) 655 99 99', N'Поставщик строительных материалов')
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [FullNameUser], [Login], [Password]) VALUES (1, N'Иванов Иван Иванович', N'ivanov', N'12345                                   ')
INSERT [dbo].[User] ([UserId], [FullNameUser], [Login], [Password]) VALUES (2, N'Петров Петр Петрович', N'petrov', N'54321                                   ')
INSERT [dbo].[User] ([UserId], [FullNameUser], [Login], [Password]) VALUES (3, N'Сидоров Сидор Сидорович', N'sidorov', N'qwerty                                  ')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[DocumentEmployee]  WITH CHECK ADD  CONSTRAINT [FK_DocumentEmployee_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([EmployeeId])
GO
ALTER TABLE [dbo].[DocumentEmployee] CHECK CONSTRAINT [FK_DocumentEmployee_Employee]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([IdPost])
REFERENCES [dbo].[Post] ([PostId])
GO
ALTER TABLE [dbo].[Equipment]  WITH CHECK ADD FOREIGN KEY([IdFacilities])
REFERENCES [dbo].[Facilities] ([FacilitiesId])
GO
ALTER TABLE [dbo].[Equipment]  WITH CHECK ADD  CONSTRAINT [FK_Equipment_Suppliers] FOREIGN KEY([IdSuppliers])
REFERENCES [dbo].[Suppliers] ([SupplierId])
GO
ALTER TABLE [dbo].[Equipment] CHECK CONSTRAINT [FK_Equipment_Suppliers]
GO
ALTER TABLE [dbo].[ScheduleEmployee]  WITH CHECK ADD FOREIGN KEY([IdEmployee])
REFERENCES [dbo].[Employee] ([EmployeeId])
GO
