CREATE DATABASE DTSMCC;

CREATE TABLE Perusahaan(
	IdPerusahaan VARCHAR(5) NOT NULL,
	CONSTRAINT PKPerusahaan PRIMARY KEY (IdPerusahaan),
	TipePerusahaan VARCHAR(50) NOT NULL
);

CREATE TABLE Provinsi(
	IdProvinsi VARCHAR(5) NOT NULL,
	CONSTRAINT PKProvinsi PRIMARY KEY (IdProvinsi),
	NamaProvinsi VARCHAR(50) UNIQUE NOT NULL
);

CREATE TABLE Grade(
	IdGrade VARCHAR(5) NOT NULL,
	CONSTRAINT PKGrade PRIMARY KEY (IdGrade),
	Grade VARCHAR(1) UNIQUE NOT NULL,
	Gaji INT NOT NULL
);

CREATE TABLE Manager(
	IdManager VARCHAR(5) NOT NULL,
	CONSTRAINT PKManager PRIMARY KEY (IdManager),
	NamaManager VARCHAR(50) NOT NULL,
	AlamatManager VARCHAR(50) NOT NULL,
	NoTelpManager BIGINT NOT NULL,
	EmailManager VARCHAR(50) NOT NULL
);

CREATE TABLE Penempatan(
	IdPenempatan VARCHAR(5) NOT NULL,
	CONSTRAINT PKPenempatan PRIMARY KEY (IdPenempatan),
	NamaPerusahaan VARCHAR(50) NOT NULL,
	IdPerusahaan VARCHAR(5) NOT NULL,
	CONSTRAINT FKIdPerusahaan FOREIGN KEY (IdPerusahaan) REFERENCES Perusahaan(IdPerusahaan),
	IdProvinsi VARCHAR(5) NOT NULL,
	CONSTRAINT FKIdProvinsi FOREIGN KEY (IdProvinsi) REFERENCES Provinsi(IdProvinsi)
);

CREATE TABLE Pegawai(
	IdPegawai INT NOT NULL,
	CONSTRAINT PKPegawai PRIMARY KEY (IdPegawai),
	NamaPegawai VARCHAR(50) NOT NULL,
	AlamatPegawai VARCHAR(50) NOT NULL,
	NoTelpPegawai BIGINT NOT NULL,
	EmailPegawai VARCHAR(50) NOT NULL,
	JenisKelamin VARCHAR(50) NOT NULL,
	IdGrade VARCHAR(5) NOT NULL,
	CONSTRAINT FKIdGrade FOREIGN KEY (IdGrade) REFERENCES Grade(IdGrade),
	IdManager VARCHAR(5) NOT NULL,
	CONSTRAINT FKIdManager FOREIGN KEY (IdManager) REFERENCES Manager(IdManager),
	IdPenempatan VARCHAR(5) NOT NULL,
	CONSTRAINT FKIdPenempatan FOREIGN KEY (IdPenempatan) REFERENCES Penempatan(IdPenempatan)
);

-- Command dibawah melakukan input data pada tabel Provinsi
INSERT INTO Provinsi VALUES
('JBT', 'Jawa Barat'),
('JTH', 'Jawa Tengah'),
('JTR', 'Jawa Timur');

-- Command dibawah melakukan input data pada tabel Perusahaan
INSERT INTO Perusahaan VALUES
('A1', 'Perbankan'),
('A2', 'Perpajakan'),
('A3', 'Telekomunikasi');

-- Command dibawah melakukan input data pada tabel Grade
INSERT INTO Grade VALUES
('GA', 'A', 5500000),
('GB', 'B', 5000000),
('GC', 'C', 4500000);

-- Command dibawah melakukan input data pada tabel Manager
INSERT INTO Manager VALUES
('M1', 'Supra Yogi', 'Jl Telekomunikasi no 41', 081253536100, 'supsup@gmail.com'),
('M2', 'Bayu Firdaus', 'Jl Durian Runtuh no 11', 081348955830, 'bayu@gmail.com'),
('M3', 'Muhammad Amien', 'Gg PGA no 9', 081378815250, 'amien@gmail.com');

-- Command dibawah melakukan input data pada tabel Penempatan
INSERT INTO Penempatan VALUES
('P1', 'Bea Cukai', 'A2', 'JTH'),
('P2', 'BNI', 'A1', 'JTR'),
('P3', 'Telkomsel', 'A3', 'JBT');

-- Command dibawah melakukan input data pada tabel Pegawai
INSERT INTO Pegawai VALUES
(1301174265, 'Jodi Kusuma', 'Jl Mandala Utara no 16', 081348915240, 'jodikusuma@gmail.com', 'Laki - Laki', 'GA', 'M2', 'P2'),
(1301174199, 'Siti Nurbaya', 'Jl Comet no 4', 085641227878, 'nurbayasiti@gmail.com', 'Perempuan', 'GA', 'M1', 'P3'),
(1301176011, 'Siti Barbara', 'Jl Comet no 4', 081687872199, 'sitibarbara@gmail.com', 'Perempuan', 'GB', 'M2', 'P1'),
(1301173591, 'Alvinda Julian', 'Jl Kebangsaan V no 15', 081221125671, 'julianto@gmail.com', 'Laki - Laki', 'GA', 'M2', 'P2'),
(1301176255, 'Agus Alfredo', 'Jl Manggis I no 8', 089671229790, 'agoes@gmail.com', 'Laki - Laki', 'GC', 'M1', 'P2');