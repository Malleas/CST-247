using Benchmark.Models;
using Benchmark.Services.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Unity;

namespace Benchmark.Services.Data
{
    public class VerseDAO
    {
        [Dependency]
        public ILogger logger { get; set; }

        public bool createVerse(Verse verse)
        {
            string connectionString = "Server =.; Database = Benchmark; Trusted_Connection = True";
            string query = "INSERT INTO dbo.Verse (Testament, Book, ChapterNumber, VerseNumber, VerseText) " +
                "VALUES ( @testament, @book, @chapterNumber, @verseNumber, @verseText)";
            bool results = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@testament", verse.Testament);
                    command.Parameters.AddWithValue("@book", verse.Book);
                    command.Parameters.AddWithValue("@chapterNumber", verse.ChapterNumber);
                    command.Parameters.AddWithValue("@verseNumber", verse.VerseNumber);
                    command.Parameters.AddWithValue("@verseText", verse.VerseText);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    logger.Info("Verse added successfully");
                    results = true;

                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return results;
        }

        public List<Verse> GetVerse(Verse verse)
        {
            string testament = "''";
            string book = "''";
            string chapterNumber = "''";
            string verseNumber = "''";
            string verseText = "''";

            if (verse.Testament != null)
            {
                testament = verse.Testament;
            }
            if (verse.Book != null)
            {
                book = verse.Book;
            }
            if (verse.ChapterNumber != null)
            {
                chapterNumber = verse.ChapterNumber;
            }
            if (verse.VerseNumber != null)
            {
                verseNumber = verse.VerseNumber;
            }
            if (verse.VerseText != null)
            {
                verseText = verse.VerseText;
            }

            string connectionString = "Server =.; Database = Benchmark; Trusted_Connection = True";
            string query = "Select * from dbo.Verse where Testament like " + "'%"+ testament +"%'" +
                " or Book like " + "'%" + book + "%'"+
                " or ChapterNumber like " + "'%" + chapterNumber + "%'" +
                " or VerseNumber like " + "'%" + verseNumber + "%'" + 
                " or VerseText like " + "'%" + verseText + "%'" + "";
            List<Verse> results = new List<Verse>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    int recordCount = 0;
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Verse resultsVerse = new Verse();
                            resultsVerse.Testament = reader.GetString(1);
                            resultsVerse.Book = reader.GetString(2);
                            resultsVerse.ChapterNumber = reader.GetString(3);
                            resultsVerse.VerseNumber = reader.GetString(4);
                            resultsVerse.VerseText = reader.GetString(5);
                            results.Add(resultsVerse);
                            recordCount++;
                        }
                    }
                    logger.Info(recordCount + " records found");
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return results;
        }


    }
}