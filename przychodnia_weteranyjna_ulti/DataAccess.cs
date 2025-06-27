using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace przychodnia_weteranyjna_ulti
{
    public class DataAccess
    {
        private readonly string _connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Przychodnia.accdb;";

        #region Metody dla Lekarzy
        public List<LekarzWeterynarii> GetLekarze()
        {
            var lekarze = new List<LekarzWeterynarii>();
            string query = "SELECT * FROM [Lekarze];";
            using (var connection = new OleDbConnection(_connectionString))
            {
                var command = new OleDbCommand(query, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lekarze.Add(new LekarzWeterynarii
                        {
                            Id = Convert.ToInt32(reader["ID"]),
                            Imie = reader["Imie"].ToString() ?? "",
                            Nazwisko = reader["Nazwisko"].ToString() ?? "",
                            NumerTelefonu = reader["NumerTelefonu"].ToString() ?? "",
                            NumerPWZ = reader["NumerPWZ"].ToString() ?? "",
                            Specjalizacja = reader["Specjalizacja"].ToString() ?? ""
                        });
                    }
                }
            }
            return lekarze;
        }
        public void AddLekarz(LekarzWeterynarii lekarz)
        {
            string query = "INSERT INTO [Lekarze] ([Imie], [Nazwisko], [NumerTelefonu], [NumerPWZ], [Specjalizacja]) VALUES (@Imie, @Nazwisko, @NumerTelefonu, @NumerPWZ, @Specjalizacja);";
            using (var connection = new OleDbConnection(_connectionString))
            {
                var command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@Imie", lekarz.Imie);
                command.Parameters.AddWithValue("@Nazwisko", lekarz.Nazwisko);
                command.Parameters.AddWithValue("@NumerTelefonu", lekarz.NumerTelefonu);
                command.Parameters.AddWithValue("@NumerPWZ", lekarz.NumerPWZ);
                command.Parameters.AddWithValue("@Specjalizacja", lekarz.Specjalizacja);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void UpdateLekarz(LekarzWeterynarii lekarz)
        {
            string query = "UPDATE [Lekarze] SET [Imie] = @Imie, [Nazwisko] = @Nazwisko, [NumerTelefonu] = @NumerTelefonu, [NumerPWZ] = @NumerPWZ, [Specjalizacja] = @Specjalizacja WHERE [ID] = @ID;";
            using (var connection = new OleDbConnection(_connectionString))
            {
                var command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@Imie", lekarz.Imie);
                command.Parameters.AddWithValue("@Nazwisko", lekarz.Nazwisko);
                command.Parameters.AddWithValue("@NumerTelefonu", lekarz.NumerTelefonu);
                command.Parameters.AddWithValue("@NumerPWZ", lekarz.NumerPWZ);
                command.Parameters.AddWithValue("@Specjalizacja", lekarz.Specjalizacja);
                command.Parameters.AddWithValue("@ID", lekarz.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void DeleteLekarz(int lekarzId)
        {
            string query = "DELETE FROM [Lekarze] WHERE [ID] = @ID;";
            using (var connection = new OleDbConnection(_connectionString))
            {
                var command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@ID", lekarzId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Metody dla Klientów
        public List<Klient> GetKlienci()
        {
            var klienci = new List<Klient>();
            string query = "SELECT * FROM [Klienci];";
            using (var connection = new OleDbConnection(_connectionString))
            {
                var command = new OleDbCommand(query, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        klienci.Add(new Klient
                        {
                            Id = Convert.ToInt32(reader["ID"]),
                            Imie = reader["Imie"].ToString() ?? "",
                            Nazwisko = reader["Nazwisko"].ToString() ?? "",
                            NumerTelefonu = reader["NumerTelefonu"].ToString() ?? "",
                            Email = reader["Email"].ToString() ?? "",
                            Adres = reader["Adres"].ToString() ?? ""
                        });
                    }
                }
            }
            return klienci;
        }
        public void AddKlient(Klient klient)
        {
            string query = "INSERT INTO [Klienci] ([Imie], [Nazwisko], [NumerTelefonu], [Email], [Adres]) VALUES (@Imie, @Nazwisko, @NumerTelefonu, @Email, @Adres);";
            using (var connection = new OleDbConnection(_connectionString))
            {
                var command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@Imie", klient.Imie);
                command.Parameters.AddWithValue("@Nazwisko", klient.Nazwisko);
                command.Parameters.AddWithValue("@NumerTelefonu", klient.NumerTelefonu);
                command.Parameters.AddWithValue("@Email", klient.Email);
                command.Parameters.AddWithValue("@Adres", klient.Adres);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void UpdateKlient(Klient klient)
        {
            string query = "UPDATE [Klienci] SET [Imie] = @Imie, [Nazwisko] = @Nazwisko, [NumerTelefonu] = @NumerTelefonu, [Email] = @Email, [Adres] = @Adres WHERE [ID] = @ID;";
            using (var connection = new OleDbConnection(_connectionString))
            {
                var command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@Imie", klient.Imie);
                command.Parameters.AddWithValue("@Nazwisko", klient.Nazwisko);
                command.Parameters.AddWithValue("@NumerTelefonu", klient.NumerTelefonu);
                command.Parameters.AddWithValue("@Email", klient.Email);
                command.Parameters.AddWithValue("@Adres", klient.Adres);
                command.Parameters.AddWithValue("@ID", klient.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void DeleteKlient(int klientId)
        {
            string query = "DELETE FROM [Klienci] WHERE [ID] = @ID;";
            using (var connection = new OleDbConnection(_connectionString))
            {
                var command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@ID", klientId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Metody dla Zwierząt
        public List<Zwierze> GetZwierzeta()
        {
            var zwierzeta = new List<Zwierze>();
            string query = "SELECT * FROM [Zwierzeta];";
            using (var connection = new OleDbConnection(_connectionString))
            {
                var command = new OleDbCommand(query, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var zwierze = new Zwierze
                        {
                            Id = Convert.ToInt32(reader["ID"]),
                            Imie = reader["Imie"].ToString() ?? "",
                            Gatunek = reader["Gatunek"].ToString() ?? "",
                            Rasa = reader["Rasa"].ToString() ?? "",
                            DataUrodzenia = Convert.ToDateTime(reader["DataUrodzenia"]),
                            Wlasciciel = new Klient { Id = Convert.ToInt32(reader["WlascicielID"]) }
                        };
                        zwierzeta.Add(zwierze);
                    }
                }
            }
            return zwierzeta;
        }
        public void AddZwierze(Zwierze zwierze)
        {
            string query = "INSERT INTO [Zwierzeta] ([Imie], [Gatunek], [Rasa], [DataUrodzenia], [WlascicielID]) VALUES (@Imie, @Gatunek, @Rasa, @DataUrodzenia, @WlascicielID);";
            using (var connection = new OleDbConnection(_connectionString))
            {
                var command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@Imie", zwierze.Imie);
                command.Parameters.AddWithValue("@Gatunek", zwierze.Gatunek);
                command.Parameters.AddWithValue("@Rasa", zwierze.Rasa);
                command.Parameters.Add("@DataUrodzenia", OleDbType.Date).Value = zwierze.DataUrodzenia;
                command.Parameters.AddWithValue("@WlascicielID", zwierze.Wlasciciel.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void UpdateZwierze(Zwierze zwierze)
        {
            string query = "UPDATE [Zwierzeta] SET [Imie] = @Imie, [Gatunek] = @Gatunek, [Rasa] = @Rasa, [DataUrodzenia] = @DataUrodzenia WHERE [ID] = @ID;";
            using (var connection = new OleDbConnection(_connectionString))
            {
                var command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@Imie", zwierze.Imie);
                command.Parameters.AddWithValue("@Gatunek", zwierze.Gatunek);
                command.Parameters.AddWithValue("@Rasa", zwierze.Rasa);
                command.Parameters.Add("@DataUrodzenia", OleDbType.Date).Value = zwierze.DataUrodzenia;
                command.Parameters.AddWithValue("@ID", zwierze.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void DeleteZwierze(int zwierzeId)
        {
            string query = "DELETE FROM [Zwierzeta] WHERE [ID] = @ID;";
            using (var connection = new OleDbConnection(_connectionString))
            {
                var command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@ID", zwierzeId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Metody dla Wizyt
        public List<Wizyta> GetWizyty()
        {
            var wizyty = new List<Wizyta>();
            string query = "SELECT * FROM [Wizyty];";
            using (var connection = new OleDbConnection(_connectionString))
            {
                var command = new OleDbCommand(query, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var wizyta = new Wizyta
                        {
                            Id = Convert.ToInt32(reader["ID"]),
                            DataWizyty = Convert.ToDateTime(reader["DataWizyty"]),
                            Opis = reader["Opis"].ToString() ?? "",
                            Status = reader["Status"].ToString() ?? "",
                            Lekarz = new LekarzWeterynarii { Id = Convert.ToInt32(reader["LekarzID"]) },
                            Pacjent = new Zwierze { Id = Convert.ToInt32(reader["PacjentID"]) },
                            Badanie = reader["Badanie"].ToString() ?? "",
                            Diagnoza = reader["Diagnoza"].ToString() ?? "",
                            Zalecenia = reader["Zalecenia"].ToString() ?? "",
                            Leki = reader["Leki"].ToString() ?? "",
                            DataKontroli = reader["DataKontroli"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["DataKontroli"]),
                            Waga = reader["Waga"] == DBNull.Value ? 0 : Convert.ToSingle(reader["Waga"]),
                            Temperatura = reader["Temperatura"] == DBNull.Value ? 0 : Convert.ToSingle(reader["Temperatura"]),
                            KosztWizyty = reader["KosztWizyty"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["KosztWizyty"])
                        };
                        wizyty.Add(wizyta);
                    }
                }
            }
            return wizyty;
        }
        public List<Wizyta> GetWizytyByPacjentId(int pacjentId)
        {
            var wizyty = new List<Wizyta>();
            string query = "SELECT * FROM [Wizyty] WHERE [PacjentID] = @PacjentID;";
            using (var connection = new OleDbConnection(_connectionString))
            {
                var command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@PacjentID", pacjentId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        wizyty.Add(new Wizyta
                        {
                            Id = Convert.ToInt32(reader["ID"]),
                            DataWizyty = Convert.ToDateTime(reader["DataWizyty"]),
                            Opis = reader["Opis"].ToString() ?? "",
                            Status = reader["Status"].ToString() ?? "",
                            Lekarz = new LekarzWeterynarii { Id = Convert.ToInt32(reader["LekarzID"]) },
                            Pacjent = new Zwierze { Id = Convert.ToInt32(reader["PacjentID"]) },
                            Badanie = reader["Badanie"].ToString() ?? "",
                            Diagnoza = reader["Diagnoza"].ToString() ?? "",
                            Zalecenia = reader["Zalecenia"].ToString() ?? "",
                            Leki = reader["Leki"].ToString() ?? "",
                            DataKontroli = reader["DataKontroli"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["DataKontroli"]),
                            Waga = reader["Waga"] == DBNull.Value ? 0 : Convert.ToSingle(reader["Waga"]),
                            Temperatura = reader["Temperatura"] == DBNull.Value ? 0 : Convert.ToSingle(reader["Temperatura"]),
                            KosztWizyty = reader["KosztWizyty"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["KosztWizyty"])
                        });
                    }
                }
            }
            return wizyty;
        }
        public void AddWizyta(Wizyta wizyta)
        {
            string query = "INSERT INTO [Wizyty] ([DataWizyty], [LekarzID], [PacjentID], [Opis], [Status], [Badanie], [Diagnoza], [Zalecenia], [Leki], [DataKontroli], [Waga], [Temperatura], [KosztWizyty]) VALUES (@DataWizyty, @LekarzID, @PacjentID, @Opis, @Status, @Badanie, @Diagnoza, @Zalecenia, @Leki, @DataKontroli, @Waga, @Temperatura, @KosztWizyty);";
            using (var connection = new OleDbConnection(_connectionString))
            {
                var command = new OleDbCommand(query, connection);
                command.Parameters.Add("@DataWizyty", OleDbType.Date).Value = wizyta.DataWizyty;
                command.Parameters.AddWithValue("@LekarzID", wizyta.Lekarz.Id);
                command.Parameters.AddWithValue("@PacjentID", wizyta.Pacjent.Id);
                command.Parameters.AddWithValue("@Opis", wizyta.Opis);
                command.Parameters.AddWithValue("@Status", wizyta.Status);
                command.Parameters.AddWithValue("@Badanie", wizyta.Badanie);
                command.Parameters.AddWithValue("@Diagnoza", wizyta.Diagnoza);
                command.Parameters.AddWithValue("@Zalecenia", wizyta.Zalecenia);
                command.Parameters.AddWithValue("@Leki", wizyta.Leki);
                command.Parameters.AddWithValue("@DataKontroli", wizyta.DataKontroli.HasValue ? (object)wizyta.DataKontroli.Value : DBNull.Value);
                command.Parameters.AddWithValue("@Waga", wizyta.Waga);
                command.Parameters.AddWithValue("@Temperatura", wizyta.Temperatura);
                command.Parameters.AddWithValue("@KosztWizyty", wizyta.KosztWizyty);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void UpdateWizyta(Wizyta wizyta)
        {
            string query = "UPDATE [Wizyty] SET [DataWizyty] = @DataWizyty, [LekarzID] = @LekarzID, [PacjentID] = @PacjentID, [Opis] = @Opis, [Status] = @Status, [Badanie] = @Badanie, [Diagnoza] = @Diagnoza, [Zalecenia] = @Zalecenia, [Leki] = @Leki, [DataKontroli] = @DataKontroli, [Waga] = @Waga, [Temperatura] = @Temperatura, [KosztWizyty] = @KosztWizyty WHERE [ID] = @ID;";
            using (var connection = new OleDbConnection(_connectionString))
            {
                var command = new OleDbCommand(query, connection);
                command.Parameters.Add("@DataWizyty", OleDbType.Date).Value = wizyta.DataWizyty;
                command.Parameters.AddWithValue("@LekarzID", wizyta.Lekarz.Id);
                command.Parameters.AddWithValue("@PacjentID", wizyta.Pacjent.Id);
                command.Parameters.AddWithValue("@Opis", wizyta.Opis);
                command.Parameters.AddWithValue("@Status", wizyta.Status);
                command.Parameters.AddWithValue("@Badanie", wizyta.Badanie);
                command.Parameters.AddWithValue("@Diagnoza", wizyta.Diagnoza);
                command.Parameters.AddWithValue("@Zalecenia", wizyta.Zalecenia);
                command.Parameters.AddWithValue("@Leki", wizyta.Leki);
                var dataKontroliParam = new OleDbParameter("@DataKontroli", OleDbType.Date);
                if (wizyta.DataKontroli.HasValue) { dataKontroliParam.Value = wizyta.DataKontroli.Value; } else { dataKontroliParam.Value = DBNull.Value; }
                command.Parameters.Add(dataKontroliParam);
                command.Parameters.AddWithValue("@Waga", wizyta.Waga);
                command.Parameters.AddWithValue("@Temperatura", wizyta.Temperatura);
                command.Parameters.AddWithValue("@KosztWizyty", wizyta.KosztWizyty);
                command.Parameters.AddWithValue("@ID", wizyta.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void DeleteWizyta(int wizytaId)
        {
            string query = "DELETE FROM [Wizyty] WHERE [ID] = @ID;";
            using (var connection = new OleDbConnection(_connectionString))
            {
                var command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@ID", wizytaId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        #endregion
    }
}