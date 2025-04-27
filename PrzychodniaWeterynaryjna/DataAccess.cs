using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PrzychodniaWeterynaryjna
{
    public class DataAccess
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\tomas\\OneDrive\\Desktop\\programowanie obiektowe\\PrzychodniaWeterynaryjna2\\PrzychodniaWeterynaryjna\\Baza_Danych\\Dane.accdb;Persist Security Info=False;";
        private OleDbConnection GetConnection()
        {
            return new OleDbConnection(connectionString);
        }

        public Uzytkownik PobierzUzytkownika(string login, string haslo)
        {
            Uzytkownik uzytkownik = null;
            using (OleDbConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT IdUzytkownika, Imie, Nazwisko, Login, Haslo, Rola FROM Uzytkownicy WHERE Login = @Login AND Haslo = @Haslo";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Login", login);
                        command.Parameters.AddWithValue("@Haslo", haslo);
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                uzytkownik = new Uzytkownik(
                                    reader.GetInt32(0),     // IdUzytkownika
                                    reader.GetString(1),     // Imie
                                    reader.GetString(2),     // Nazwisko
                                    reader.GetString(3),     // Login
                                    reader.GetString(4),     // Haslo
                                    reader.GetString(5)      // Rola
                                );
                            }
                        }
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"Błąd bazy danych (PobierzUzytkownika): {ex.Message}");
                    Console.WriteLine(ex.ToString());
                }
            }
            return uzytkownik;
        }

        public bool DodajKlienta(Klient klient)
        {
            using (OleDbConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Klienci (Imie, Nazwisko, Adres, Telefon) VALUES (@Imie, @Nazwisko, @Adres, @Telefon)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Imie", klient.Imie);
                        command.Parameters.AddWithValue("@Nazwisko", klient.Nazwisko);
                        command.Parameters.AddWithValue("@Adres", klient.Adres);
                        command.Parameters.AddWithValue("@Telefon", klient.Telefon);
                        return command.ExecuteNonQuery() > 0;
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"Błąd bazy danych: {ex.Message}");
                    return false;
                }
            }
        }

        public bool DodajPacjenta(Pacjent pacjent)
        {
            using (OleDbConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Pacjenci (ImieWlasciciela, NazwiskoWlasciciela, AdresWlasciciela, TelefonWlasciciela, Gatunek, ImieZwierzecia, DataUrodzenia, IdWlasciciela, Rasa, Uwagi) VALUES (@ImieWlasciciela, @NazwiskoWlasciciela, @AdresWlasciciela, @TelefonWlasciciela, @Gatunek, @ImieZwierzecia, @DataUrodzenia, @IdWlasciciela, @Rasa, @Uwagi)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ImieWlasciciela", pacjent.ImieWlasciciela);
                        command.Parameters.AddWithValue("@NazwiskoWlasciciela", pacjent.NazwiskoWlasciciela);
                        command.Parameters.AddWithValue("@AdresWlasciciela", pacjent.AdresWlasciciela);
                        command.Parameters.AddWithValue("@TelefonWlasciciela", pacjent.TelefonWlasciciela);
                        command.Parameters.AddWithValue("@Gatunek", pacjent.Gatunek);
                        command.Parameters.AddWithValue("@ImieZwierzecia", pacjent.ImieZwierzecia);
                        command.Parameters.AddWithValue("@DataUrodzenia", pacjent.DataUrodzenia.HasValue ? (object)pacjent.DataUrodzenia.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@IdWlasciciela", pacjent.IdWlasciciela);
                        command.Parameters.AddWithValue("@Rasa", string.IsNullOrEmpty(pacjent.Rasa) ? DBNull.Value : (object)pacjent.Rasa);
                        command.Parameters.AddWithValue("@Uwagi", string.IsNullOrEmpty(pacjent.Uwagi) ? DBNull.Value : (object)pacjent.Uwagi);
                        return command.ExecuteNonQuery() > 0;
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"Błąd bazy danych: {ex.Message}");
                    return false;
                }
            }
        }

        public bool EdytujKlienta(Klient klient)
        {
            using (OleDbConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Klienci SET Imie = @Imie, Nazwisko = @Nazwisko, Adres = @Adres, Telefon = @Telefon WHERE IdKlienta = @IdKlienta";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Imie", klient.Imie);
                        command.Parameters.AddWithValue("@Nazwisko", klient.Nazwisko);
                        command.Parameters.AddWithValue("@Adres", klient.Adres);
                        command.Parameters.AddWithValue("@Telefon", klient.Telefon);
                        command.Parameters.AddWithValue("@IdKlienta", klient.IdKlienta);
                        return command.ExecuteNonQuery() > 0;
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"Błąd bazy danych: {ex.Message}");
                    return false;
                }
            }
        }

        public List<Klient> PobierzWszystkichKlientow()
        {
            List<Klient> klienci = new List<Klient>();
            using (OleDbConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT IdKlienta, Imie, Nazwisko, Adres, Telefon FROM Klienci";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            klienci.Add(new Klient(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(4)
                            ));
                        }
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"Błąd bazy danych: {ex.Message}");
                }
            }
            return klienci;
        }

        public bool UsunKlienta(int idKlienta)
        {
            using (OleDbConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Klienci WHERE IdKlienta = @IdKlienta";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdKlienta", idKlienta);
                        return command.ExecuteNonQuery() > 0;
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"Błąd bazy danych: {ex.Message}");
                    return false;
                }
            }
        }

        public List<Pacjent> PobierzWszystkichPacjentow()
        {
            List<Pacjent> pacjenci = new List<Pacjent>();
            using (OleDbConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT IdPacjenta, ImieWlasciciela, NazwiskoWlasciciela, AdresWlasciciela, TelefonWlasciciela, Gatunek, ImieZwierzecia, DataUrodzenia, IdWlasciciela, Rasa, Uwagi FROM Pacjenci";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pacjenci.Add(new Pacjent(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(4),
                                reader.GetString(5),
                                reader.GetString(6),
                                reader.IsDBNull(7) ? (DateTime?)null : reader.GetDateTime(7),
                                reader.GetInt32(8),
                                reader.IsDBNull(9) ? null : reader.GetString(9),
                                reader.IsDBNull(10) ? null : reader.GetString(10)
                            ));
                        }
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"Błąd bazy danych: {ex.Message}");
                }
            }
            return pacjenci;
        }

        public List<Pacjent> PobierzZwierzetaDlaWlasciciela(int idWlasciciela)
        {
            List<Pacjent> pacjenci = new List<Pacjent>();
            using (OleDbConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT IdPacjenta, ImieWlasciciela, NazwiskoWlasciciela, AdresWlasciciela, TelefonWlasciciela, Gatunek, ImieZwierzecia, DataUrodzenia, IdWlasciciela, Rasa, Uwagi FROM Pacjenci WHERE IdWlasciciela = @IdWlasciciela";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdWlasciciela", idWlasciciela);
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                pacjenci.Add(new Pacjent(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    reader.GetString(3),
                                    reader.GetString(4),
                                    reader.GetString(5),
                                    reader.GetString(6),
                                    reader.IsDBNull(7) ? (DateTime?)null : reader.GetDateTime(7),
                                    reader.GetInt32(8),
                                    reader.IsDBNull(9) ? null : reader.GetString(9),
                                    reader.IsDBNull(10) ? null : reader.GetString(10)
                                ));
                            }
                        }
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"Błąd bazy danych: {ex.Message}");
                }
            }
            return pacjenci;
        }
    }
}