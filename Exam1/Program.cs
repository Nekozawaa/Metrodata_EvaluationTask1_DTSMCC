using Exam1.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Exam1
{
    class Program
    {
        SqlConnection sqlConnection;

        string connectionString = "Data Source = NEKOZAWA; Initial Catalog = DTSMCC; User Id = user; Password = 12345678;";
        static void Main(string[] args)
        {
            int pilihan = 0, pilihan1 = 0;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Sistem Pendaftaran Penempatan Kerja");
                Console.WriteLine("1. Create Data");
                Console.WriteLine("2. Read Data");
                Console.WriteLine("3. Update Data");
                Console.WriteLine("4. Delete Data");
                Console.WriteLine("5. Keluar Dari Sistem");
                Console.WriteLine("-----------------------");
                Console.Write("Masukkan Pilihan : ");
                pilihan = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if ((pilihan >= 1) && (pilihan <= 5))
                {
                    if (pilihan == 1)
                    {
                        do
                        {
                            Program program = new Program();
                            Console.WriteLine("");
                            Console.WriteLine("Create Data");
                            Console.WriteLine("1. Data Pegawai");
                            Console.WriteLine("2. Data Manager");
                            Console.WriteLine("3. Data Grade");
                            Console.WriteLine("4. Data Penempatan");
                            Console.WriteLine("5. Data Perusahaan");
                            Console.WriteLine("6. Data Provinsi");
                            Console.WriteLine("7. Kembali");
                            Console.WriteLine("-----------------------");
                            Console.Write("Masukkan Pilihan : ");
                            pilihan1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("");
                            if ((pilihan1 >= 1) && (pilihan1 <= 7))
                            {
                                switch (pilihan1)
                                {
                                    case 1:
                                        Pegawai pegawai = new Pegawai();
                                        Console.Write("Masukkan ID Pegawai        : ");
                                        pegawai.idPegawai = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Masukkan Nama Pegawai      : ");
                                        pegawai.namaPegawai = Console.ReadLine();
                                        Console.Write("Masukkan Alamat Pegawai    : ");
                                        pegawai.alamatPegawai = Console.ReadLine();
                                        Console.Write("Masukkan No Telpon Pegawai : ");
                                        pegawai.notelpPegawai = Console.ReadLine();
                                        Console.Write("Masukkan Email Pegawai     : ");
                                        pegawai.emailPegawai = Console.ReadLine();
                                        Console.Write("Masukkan Jenis Kelamin     : ");
                                        pegawai.jenisKelamin = Console.ReadLine();

                                        Console.WriteLine();
                                        program.ViewAllData("Grade");
                                        Console.Write("Masukkan ID Grade          : ");
                                        pegawai.idGrade = Console.ReadLine();

                                        Console.WriteLine();
                                        program.ViewAllData("Manager");
                                        Console.Write("Masukkan ID Manager        : ");
                                        pegawai.idManager = Console.ReadLine();

                                        Console.WriteLine();
                                        program.ViewAllData("Penempatan");
                                        Console.Write("Masukkan ID Penempatan     : ");
                                        pegawai.idPenempatan = Console.ReadLine();
                                        program.InsertPegawai(pegawai);
                                        break;
                                    case 2:
                                        Manager manager = new Manager();
                                        Console.Write("Masukkan ID Manager        : ");
                                        manager.idManager = Console.ReadLine();
                                        Console.Write("Masukkan Nama Manager      : ");
                                        manager.namaManager = Console.ReadLine();
                                        Console.Write("Masukkan Alamat Manager    : ");
                                        manager.alamatManager = Console.ReadLine();
                                        Console.Write("Masukkan No Telpon Manager : ");
                                        manager.notelpManager = Console.ReadLine();
                                        Console.Write("Masukkan Email Manager     : ");
                                        manager.emailManager = Console.ReadLine();
                                        program.InsertManager(manager);
                                        break;
                                    case 3:
                                        Grade grade = new Grade();
                                        Console.Write("Masukkan ID Grade : ");
                                        grade.idGrade = Console.ReadLine();
                                        Console.Write("Masukkan Grade    : ");
                                        grade.grade = Console.ReadLine();
                                        Console.Write("Masukkan Gaji     : ");
                                        grade.gaji = Convert.ToInt32(Console.ReadLine());
                                        program.InsertGrade(grade);
                                        break;
                                    case 4:
                                        Penempatan penempatan = new Penempatan();
                                        Console.Write("Masukkan ID Penempatan        : ");
                                        penempatan.idPenempatan = Console.ReadLine();
                                        Console.Write("Masukkan Nama Perusahaan      : ");
                                        penempatan.namaPerusahaan = Console.ReadLine();

                                        Console.WriteLine();
                                        program.ViewAllData("Perusahaan");
                                        Console.Write("Masukkan ID Perusahaan        : ");
                                        penempatan.idPerusahaan = Console.ReadLine();

                                        Console.WriteLine();
                                        program.ViewAllData("Provinsi");
                                        Console.Write("Masukkan ID Provinsi          : ");
                                        penempatan.idProvinsi = Console.ReadLine();
                                        program.InsertPenempatan(penempatan);
                                        break;
                                    case 5:
                                        Perusahaan perusahaan = new Perusahaan();
                                        Console.Write("Masukkan ID Perusahaan   : ");
                                        perusahaan.idPerusahaan = Console.ReadLine();
                                        Console.Write("Masukkan Tipe Perusahaan : ");
                                        perusahaan.tipePerusahaan = Console.ReadLine();
                                        program.InsertPerusahaan(perusahaan);
                                        break;
                                    case 6:
                                        Provinsi provinsi = new Provinsi();
                                        Console.Write("Masukkan ID Provinsi   : ");
                                        provinsi.idProvinsi = Console.ReadLine();  
                                        Console.Write("Masukkan Nama Provinsi : ");
                                        provinsi.namaProvinsi = Console.ReadLine();  
                                        program.InsertProvinsi(provinsi);
                                        break;
                                    case 7:
                                        Console.Clear();
                                        break;
                                }
                            }
                            else
                            {
                                Console.Clear();
                            }
                        } while (pilihan1 != 7);
                    }
                    else if (pilihan == 2)
                    {
                        do
                        {
                            Program program = new Program();
                            Console.WriteLine("");
                            Console.WriteLine("Read Data");
                            Console.WriteLine("1. Data Pegawai");
                            Console.WriteLine("2. Data Manager");
                            Console.WriteLine("3. Data Grade");
                            Console.WriteLine("4. Data Penempatan");
                            Console.WriteLine("5. Data Perusahaan");
                            Console.WriteLine("6. Data Provinsi");
                            Console.WriteLine("7. Kembali");
                            Console.WriteLine("-----------------------");
                            Console.Write("Masukkan Pilihan : ");
                            pilihan1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("");
                            if ((pilihan1 >= 1) && (pilihan1 <= 7))
                            {
                                switch (pilihan1)
                                {
                                    case 1:
                                        program.ViewAllData("Pegawai");
                                        break;
                                    case 2:
                                        program.ViewAllData("Manager");
                                        break;
                                    case 3:
                                        program.ViewAllData("Grade");
                                        break;
                                    case 4:
                                        program.ViewAllData("Penempatan");
                                        break;
                                    case 5:
                                        program.ViewAllData("Perusahaan");
                                        break;
                                    case 6:
                                        program.ViewAllData("Provinsi");
                                        break;
                                    case 7:
                                        Console.Clear();
                                        break;
                                }
                            }else
                            {
                                Console.Clear();
                            }
                        } while (pilihan1 != 7);
                    }
                    else if (pilihan == 3)
                    {
                        do
                        {
                            Program program = new Program();
                            Console.WriteLine("");
                            Console.WriteLine("Update Data");
                            Console.WriteLine("1. Data Pegawai");
                            Console.WriteLine("2. Data Manager");
                            Console.WriteLine("3. Data Grade");
                            Console.WriteLine("4. Data Penempatan");
                            Console.WriteLine("5. Data Perusahaan");
                            Console.WriteLine("6. Data Provinsi");
                            Console.WriteLine("7. Kembali");
                            Console.WriteLine("-----------------------");
                            Console.Write("Masukkan Pilihan : ");
                            pilihan1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("");
                            if ((pilihan1 >= 1) && (pilihan1 <= 7))
                            {
                                switch (pilihan1)
                                {
                                    case 1:
                                        program.ViewAllData("Pegawai");
                                        Console.WriteLine("-----------------------------------------------------------------------");
                                        Pegawai pegawai = new Pegawai();
                                        Console.Write("Masukkan ID Pegawai        : ");
                                        pegawai.idPegawai = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Masukkan Nama Pegawai      : ");
                                        pegawai.namaPegawai = Console.ReadLine();
                                        Console.Write("Masukkan Alamat Pegawai    : ");
                                        pegawai.alamatPegawai = Console.ReadLine();
                                        Console.Write("Masukkan No Telpon Pegawai : ");
                                        pegawai.notelpPegawai = Console.ReadLine();
                                        Console.Write("Masukkan Email Pegawai     : ");
                                        pegawai.emailPegawai = Console.ReadLine();
                                        Console.Write("Masukkan Jenis Kelamin     : ");
                                        pegawai.jenisKelamin = Console.ReadLine();

                                        Console.WriteLine();
                                        program.ViewAllData("Grade");
                                        Console.Write("Masukkan ID Grade          : ");
                                        pegawai.idGrade = Console.ReadLine();

                                        Console.WriteLine();
                                        program.ViewAllData("Manager");
                                        Console.Write("Masukkan ID Manager        : ");
                                        pegawai.idManager = Console.ReadLine();

                                        Console.WriteLine();
                                        program.ViewAllData("Penempatan");
                                        Console.Write("Masukkan ID Penempatan     : ");
                                        pegawai.idPenempatan = Console.ReadLine();
                                        program.UpdatePegawai(pegawai);
                                        break;
                                    case 2:
                                        program.ViewAllData("Manager");
                                        Console.WriteLine("-----------------------------------------------------------------------");
                                        Manager manager = new Manager();
                                        Console.Write("Masukkan ID Manager        : ");
                                        manager.idManager = Console.ReadLine();
                                        Console.Write("Masukkan Nama Manager      : ");
                                        manager.namaManager = Console.ReadLine();
                                        Console.Write("Masukkan Alamat Manager    : ");
                                        manager.alamatManager = Console.ReadLine();
                                        Console.Write("Masukkan No Telpon Manager : ");
                                        manager.notelpManager = Console.ReadLine();
                                        Console.Write("Masukkan Email Manager     : ");
                                        manager.emailManager = Console.ReadLine();
                                        program.UpdateManager(manager);
                                        break;
                                    case 3:
                                        program.ViewAllData("Grade");
                                        Console.WriteLine("-----------------------------------------------------------------------");
                                        Grade grade = new Grade();
                                        Console.Write("Masukkan ID Grade : ");
                                        grade.idGrade = Console.ReadLine();
                                        Console.Write("Masukkan Grade    : ");
                                        grade.grade = Console.ReadLine();
                                        Console.Write("Masukkan Gaji     : ");
                                        grade.gaji = Convert.ToInt32(Console.ReadLine());
                                        program.UpdateGrade(grade);
                                        break;
                                    case 4:
                                        program.ViewAllData("Penempatan");
                                        Console.WriteLine("-----------------------------------------------------------------------");
                                        Penempatan penempatan = new Penempatan();
                                        Console.Write("Masukkan ID Penempatan        : ");
                                        penempatan.idPenempatan = Console.ReadLine();
                                        Console.Write("Masukkan Nama Perusahaan      : ");
                                        penempatan.namaPerusahaan = Console.ReadLine();

                                        Console.WriteLine();
                                        program.ViewAllData("Perusahaan");
                                        Console.Write("Masukkan ID Perusahaan        : ");
                                        penempatan.idPerusahaan = Console.ReadLine();

                                        Console.WriteLine();
                                        program.ViewAllData("Provinsi");
                                        Console.Write("Masukkan ID Provinsi          : ");
                                        penempatan.idProvinsi = Console.ReadLine();
                                        program.UpdatePenempatan(penempatan);
                                        break;
                                    case 5:
                                        program.ViewAllData("Perusahaan");
                                        Console.WriteLine("-----------------------------------------------------------------------");
                                        Perusahaan perusahaan = new Perusahaan();
                                        Console.Write("Masukkan ID Perusahaan   : ");
                                        perusahaan.idPerusahaan = Console.ReadLine();
                                        Console.Write("Masukkan Tipe Perusahaan : ");
                                        perusahaan.tipePerusahaan = Console.ReadLine();
                                        program.UpdatePerusahaan(perusahaan);
                                        break;
                                    case 6:
                                        program.ViewAllData("Provinsi");
                                        Console.WriteLine("-----------------------------------------------------------------------");
                                        Provinsi provinsi = new Provinsi();
                                        Console.Write("Masukkan ID Provinsi   : ");
                                        provinsi.idProvinsi = Console.ReadLine();
                                        Console.Write("Masukkan Nama Provinsi : ");
                                        provinsi.namaProvinsi = Console.ReadLine();
                                        program.UpdateProvinsi(provinsi);
                                        break;
                                    case 7:
                                        Console.Clear();
                                        break;
                                }
                            }
                            else
                            {
                                Console.Clear();
                            }
                        } while (pilihan1 != 7);
                    }
                    else if (pilihan == 4)
                    {
                        do
                        {
                            Program program = new Program();
                            string id;
                            Console.WriteLine("");
                            Console.WriteLine("Delete Data");
                            Console.WriteLine("1. Data Pegawai");
                            Console.WriteLine("2. Data Manager");
                            Console.WriteLine("3. Data Grade");
                            Console.WriteLine("4. Data Penempatan");
                            Console.WriteLine("5. Data Perusahaan");
                            Console.WriteLine("6. Data Provinsi");
                            Console.WriteLine("7. Kembali");
                            Console.WriteLine("-----------------------");
                            Console.Write("Masukkan Pilihan : ");
                            pilihan1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("");
                            if ((pilihan1 >= 1) && (pilihan1 <= 7))
                            {
                                switch (pilihan1)
                                {
                                    case 1:
                                        program.ViewAllData("Pegawai");
                                        Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.Write("Masukkan ID Pegawai : ");
                                        int idPegawai = Convert.ToInt32(Console.ReadLine());
                                        program.DeleteDataPegawai(idPegawai);
                                        break;
                                    case 2:
                                        program.ViewAllData("Manager");
                                        Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.Write("Masukkan ID Manager : ");
                                        id = Console.ReadLine();
                                        program.DeleteData(id, "Manager");
                                        break;
                                    case 3:
                                        program.ViewAllData("Grade");
                                        Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.Write("Masukkan ID Grade : ");
                                        id = Console.ReadLine();
                                        program.DeleteData(id, "Grade");
                                        break;
                                    case 4:
                                        program.ViewAllData("Penempatan");
                                        Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.Write("Masukkan ID Penempatan : ");
                                        id = Console.ReadLine();
                                        program.DeleteData(id, "Penempatan");
                                        break;
                                    case 5:
                                        program.ViewAllData("Perusahaan");
                                        Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.Write("Masukkan ID Perusahaan : ");
                                        id = Console.ReadLine();
                                        program.DeleteData(id, "Perusahaan");
                                        break;
                                    case 6:
                                        program.ViewAllData("Provinsi");
                                        Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.Write("Masukkan ID Provinsi : ");
                                        id = Console.ReadLine();
                                        program.DeleteData(id, "Provinsi");
                                        break;
                                    case 7:
                                        Console.Clear();
                                        break;
                                }
                            }
                            else
                            {
                                Console.Clear();
                            }
                        } while (pilihan1 != 7);
                    }

                }
                else
                {
                    Console.Clear();
                }
            } while (pilihan != 5);
        }

        void InsertPegawai(Pegawai pegawai)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT into Pegawai (IdPegawai, NamaPegawai, AlamatPegawai, NoTelpPegawai, " +
                        "EmailPegawai, JenisKelamin, IdGrade, IdManager, IdPenempatan) VALUES (@id, @nama, @alamat, " +
                        "@notelp, @email, @jeniskelamin, @idgrade, @idmanager, @idpenempatan)";
                    command.Parameters.AddWithValue("@id", pegawai.idPegawai);
                    command.Parameters.AddWithValue("@nama", pegawai.namaPegawai);
                    command.Parameters.AddWithValue("@alamat", pegawai.alamatPegawai);
                    command.Parameters.AddWithValue("@notelp", pegawai.notelpPegawai);
                    command.Parameters.AddWithValue("@email", pegawai.emailPegawai);
                    command.Parameters.AddWithValue("@jeniskelamin", pegawai.jenisKelamin);
                    command.Parameters.AddWithValue("@idgrade", pegawai.idGrade);
                    command.Parameters.AddWithValue("@idmanager", pegawai.idManager);
                    command.Parameters.AddWithValue("@idpenempatan", pegawai.idPenempatan);

                    try
                    {
                        connection.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        Console.WriteLine("Terdapat Error !");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        void InsertManager(Manager manager)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT into Manager (IdManager, NamaManager, AlamatManager, NoTelpManager, EmailManager) VALUES (@id, @nama, @alamat, @notelp, @email)";
                    command.Parameters.AddWithValue("@id", manager.idManager);
                    command.Parameters.AddWithValue("@nama", manager.namaManager);
                    command.Parameters.AddWithValue("@alamat", manager.alamatManager);
                    command.Parameters.AddWithValue("@notelp", manager.notelpManager);
                    command.Parameters.AddWithValue("@email", manager.emailManager);
                    try
                    {
                        connection.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        Console.WriteLine("Terdapat Error !");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        void InsertGrade(Grade grade)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT into Grade (IdGrade, Grade, Gaji) VALUES (@id, @grade, @gaji)";
                    command.Parameters.AddWithValue("@id", grade.idGrade);
                    command.Parameters.AddWithValue("@grade", grade.grade);
                    command.Parameters.AddWithValue("@gaji", grade.gaji);
                    try
                    {
                        connection.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        Console.WriteLine("Terdapat Error !");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        void InsertPenempatan(Penempatan penempatan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT into Penempatan (IdPenempatan, NamaPerusahaan, IdPerusahaan, IdProvinsi) VALUES (@id, @nama, @idPerusahaan, @idProvinsi)";
                    command.Parameters.AddWithValue("@id", penempatan.idPenempatan);
                    command.Parameters.AddWithValue("@nama", penempatan.namaPerusahaan);
                    command.Parameters.AddWithValue("@idPerusahaan", penempatan.idPerusahaan);
                    command.Parameters.AddWithValue("@idProvinsi", penempatan.idProvinsi);
                    try
                    {
                        connection.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        Console.WriteLine("Terdapat Error !");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        void InsertPerusahaan(Perusahaan perusahaan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT into Perusahaan (IdPerusahaan, TipePerusahaan) VALUES (@id, @tipe)";
                    command.Parameters.AddWithValue("@id", perusahaan.idPerusahaan);
                    command.Parameters.AddWithValue("@tipe", perusahaan.tipePerusahaan);
                    try
                    {
                        connection.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        Console.WriteLine("Terdapat Error !");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        void InsertProvinsi(Provinsi provinsi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT into Provinsi (IdProvinsi, NamaProvinsi) VALUES (@id, @nama)";
                    command.Parameters.AddWithValue("@id", provinsi.idProvinsi);
                    command.Parameters.AddWithValue("@nama", provinsi.namaProvinsi);
                    try
                    {
                        connection.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        Console.WriteLine("Terdapat Error !");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        void ViewAllData(string table)
        {
            string query = "SELECT * FROM " + table;

            sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            try
            {
                sqlConnection.Open();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    if (sqlDataReader.HasRows)
                    {
                        if (table == "Pegawai")
                        {
                            while (sqlDataReader.Read())
                            {
                                Console.WriteLine(sqlDataReader[0] + " | " + sqlDataReader[1] + " | " + sqlDataReader[2] + " | "
                                + sqlDataReader[3] + " | " + sqlDataReader[4] + " | " + sqlDataReader[5] + " | " + sqlDataReader[6]
                                + " | " + sqlDataReader[7] + " | " + sqlDataReader[8]);
                            }
                        }else if (table == "Manager")
                        {
                            while (sqlDataReader.Read())
                            {
                                Console.WriteLine(sqlDataReader[0] + " | " + sqlDataReader[1] + " | " + sqlDataReader[2] + " | "
                                + sqlDataReader[3] + " | " + sqlDataReader[4]);
                            }
                        }else if (table == "Grade")
                        {
                            while (sqlDataReader.Read())
                            {
                                Console.WriteLine(sqlDataReader[0] + " | " + sqlDataReader[1] + " | " + sqlDataReader[2]);
                            }
                        }else if (table == "Penempatan")
                        {
                            while (sqlDataReader.Read())
                            {
                                Console.WriteLine(sqlDataReader[0] + " | " + sqlDataReader[1] + " | " + sqlDataReader[2] + " | "
                                + sqlDataReader[3]);
                            }
                        }else if (table == "Perusahaan")
                        {
                            while (sqlDataReader.Read())
                            {
                                Console.WriteLine(sqlDataReader[0] + " | " + sqlDataReader[1]);
                            }
                        }else if (table == "Provinsi")
                        {
                            while (sqlDataReader.Read())
                            {
                                Console.WriteLine(sqlDataReader[0] + " | " + sqlDataReader[1]);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Data Rows");
                    }
                    sqlDataReader.Close();
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
        }

        void UpdatePegawai(Pegawai pegawai)
        {
            var sql = "UPDATE Pegawai SET NamaPegawai = @nama, AlamatPegawai = @alamat, NoTelpPegawai = @notelp, " +
                "EmailPegawai = @email, JenisKelamin = @jeniskelamin, IdGrade = @idgrade, IdManager = @idmanager, " +
                "IdPenempatan = @idpenempatan  WHERE IdPegawai = @id";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.NVarChar).Value = pegawai.idPegawai;
                        command.Parameters.Add("@nama", SqlDbType.NVarChar).Value = pegawai.namaPegawai;
                        command.Parameters.Add("@alamat", SqlDbType.NVarChar).Value = pegawai.alamatPegawai;
                        command.Parameters.Add("@notelp", SqlDbType.NVarChar).Value = pegawai.notelpPegawai;
                        command.Parameters.Add("@email", SqlDbType.NVarChar).Value = pegawai.emailPegawai;
                        command.Parameters.Add("@jeniskelamin", SqlDbType.NVarChar).Value = pegawai.jenisKelamin;
                        command.Parameters.Add("@idgrade", SqlDbType.NVarChar).Value = pegawai.idGrade;
                        command.Parameters.Add("@idmanager", SqlDbType.NVarChar).Value = pegawai.idManager;
                        command.Parameters.Add("@idpenempatan", SqlDbType.NVarChar).Value = pegawai.idPenempatan;

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (SqlException)
            {
                Console.WriteLine("Terdapat Error !");
            }
        }
        void UpdateManager(Manager manager)
        {
            var sql = "UPDATE Manager SET NamaManager = @nama, AlamatManager = @alamat, NoTelpManager = @notelp, EmailManager = @email WHERE IdManager = @id";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.NVarChar).Value = manager.idManager;
                        command.Parameters.Add("@nama", SqlDbType.NVarChar).Value = manager.namaManager;
                        command.Parameters.Add("@alamat", SqlDbType.NVarChar).Value = manager.alamatManager;
                        command.Parameters.Add("@notelp", SqlDbType.NVarChar).Value = manager.notelpManager;
                        command.Parameters.Add("@email", SqlDbType.NVarChar).Value = manager.emailManager;


                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (SqlException)
            {
                Console.WriteLine("Terdapat Error !");
            }
        }
        void UpdateGrade(Grade grade)
        {
            var sql = "UPDATE Grade SET Gaji = @gaji WHERE IdGrade = @id";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.NVarChar).Value = grade.idGrade;
                        command.Parameters.Add("@gaji", SqlDbType.NVarChar).Value = grade.gaji;

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (SqlException)
            {
                Console.WriteLine("Terdapat Error !");
            }
        }
        void UpdatePenempatan(Penempatan penempatan)
        {
            var sql = "UPDATE Penempatan SET NamaPerusahaan = @nama, IdPerusahaan = @idperusahaan, IdProvinsi = idprovinsi WHERE IdPenempatan = @id";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.NVarChar).Value = penempatan.idPenempatan;
                        command.Parameters.Add("@nama", SqlDbType.NVarChar).Value = penempatan.namaPerusahaan;
                        command.Parameters.Add("@idperusahaan", SqlDbType.NVarChar).Value = penempatan.idPerusahaan;
                        command.Parameters.Add("@idprovinsi", SqlDbType.NVarChar).Value = penempatan.idProvinsi;

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (SqlException)
            {
                Console.WriteLine("Terdapat Error !");
            }
        }
        void UpdatePerusahaan(Perusahaan perusahaan)
        {
            var sql = "UPDATE Perusahaan SET TipePerusahaan = @tipe WHERE IdPerusahaan = @id";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.NVarChar).Value = perusahaan.idPerusahaan;
                        command.Parameters.Add("@tipe", SqlDbType.NVarChar).Value = perusahaan.tipePerusahaan;

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (SqlException)
            {
                Console.WriteLine("Terdapat Error !");
            }
        }
        void UpdateProvinsi(Provinsi provinsi)
        {
            var sql = "UPDATE provinsi SET NamaProvinsi = @nama WHERE IdProvinsi = @id";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.NVarChar).Value = provinsi.idProvinsi;
                        command.Parameters.Add("@nama", SqlDbType.NVarChar).Value = provinsi.namaProvinsi;

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (SqlException)
            {
                Console.WriteLine("Terdapat Error !");
            }
        }

        void DeleteDataPegawai(int id)
        {
            var sql = "DELETE FROM Pegawai WHERE idPegawai = @id";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (SqlException)
            {
                Console.WriteLine("Terdapat Error !");
            }
        }
        void DeleteData(string id, string tabel)
        {
            var sql = "DELETE FROM " + tabel + " WHERE id" + tabel + " = @id";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (SqlException)
            {
                Console.WriteLine("Terdapat Error !");
            }
        }
    }
}
