create database QLHS
on (
	name = StudentManagement,
	filename = 'D:\DB_SQLServer\QLHS\QLHS.mdf'
)
log on (
	name = StudentManagement_log,
	filename = 'D:\DB_SQLServer\QLHS\QLHS_LOG.ldf'
)
go
use QLHS

create table Khoa (
	maKhoa char(4) primary key not null,
	tenKhoa nvarchar(50) not null,
)

create table Lop (
	maLop char(4) primary key not null,
	tenLop nvarchar(50) not null,
	maKhoa char(4) references Khoa(maKhoa) on update cascade on delete cascade
)

create table SinhVien (
	maSV char(4) primary key not null,
	hoTen nvarchar(50) not null,
	ngaySinh date not null,
	maLop char(4) references Lop(maLop) on update cascade on delete cascade
)

create table MonHoc (
	maMonHoc char(4) primary key not null,
	tenMonHoc nvarchar(50) not null
)

create table Diem (
	maSV char(4) references SinhVien(maSV) on update cascade on delete cascade,
	maMonHoc char(4) references MonHoc(maMonHoc) on update cascade on delete cascade, 
	diem float,
	primary key (maSV, maMonHoc)
)

create table TaiKhoan (
	tenTK nvarchar(50) primary key not null,
	matKhau nvarchar(50) not null,
	tenNguoiDung nvarchar (50) not null ,
)

insert into TaiKhoan values('admin', 'admin', N'Nguyễn Văn A')

--v
insert into Khoa values('KKKT', N'Kinh tế kế toán')
insert into Khoa values('CNTT', N'Công nghệ thông tin - UDPM')

--v
insert into Lop values('CN21', N'Ứng dụng phần mềm 21', 'CNTT')
insert into Lop values('KT21', N'Kế toán 21', 'KKKT')
insert into Lop values('DN21', N'Quản trị doanh nghiệp 21', 'KKKT')
insert into Lop values('QT21', N'Quản trị mạng', 'CNTT')
	
--v 
insert into SinhVien values('QT01', N'Nguyễn Trí', '12-22-1999', 'QT21')
insert into SinhVien values('DN01', N'Nguyễn Hoàng', '12-22-1999', 'DN21')
insert into SinhVien values('CN01', N'Nguyễn Thông Hoàng Anh', '12-22-1999', 'CN21')
insert into SinhVien values('KT01', N'Nguyễn Trí Nhẫn', '12-22-1999', 'KT21')

--v
insert into MonHoc values('QTNS', N'Quản trị nhân sự')
insert into MonHoc values('JS', N'Lập trình web với ngôn ngữ Javascript')
insert into MonHoc values('TS', N'Lập trình web với ngôn ngữ Typescript')
insert into MonHoc values('EXC', N'Excel cơ bản')

--v
insert into Diem values('CN01', 'JS', 10)
insert into Diem values('CN01', 'TS', 9.8)
insert into Diem values('KT01', 'EXC', 10)


------
select * from Khoa
select * from Lop
select * from SinhVien
select * from MonHoc
select * from Diem

Select *
from SinhVien
where maLop = 'CN21'

Delete from Lop
where maLop = 'CN21'

update MonHoc
set maMonHoc = 'EXCE'
where maMonHoc = 'EXC'