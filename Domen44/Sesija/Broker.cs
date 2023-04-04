using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using System.Data;
using System.Data.OleDb;

namespace Sesija
{
    public class Broker
    {
        private static Broker instanca;
        private OleDbConnection konekcija;
        private OleDbCommand komanda;
        private Broker()
        {
            this.konekcija = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\TrecaBGD\Documents\Database17.accdb");
            this.komanda = konekcija.CreateCommand();

        }
        public static Broker DajSesiju()
        {
            if (instanca == null)
            {
                instanca = new Broker();
            }
            return instanca;
        }
        public List<Mesto> VratiSvaMesta()
        {
            List<Mesto> mesta = new List<Mesto>();
            try
            {
                komanda.CommandText = "select PttBroj, Naziv from Mesto";
                komanda.CommandType = CommandType.Text;
                konekcija.Open();
                OleDbDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    Mesto mesto = new Mesto
                    {
                        PttBroj = (int)citac["PttBroj"],
                        Naziv = citac["Naziv"].ToString()
                    };
                    mesta.Add(mesto);

                }
                return mesta;
            }

            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();

                }

            }
        }
        public int UbaciMestouBazu(Mesto m)
        {
            try
            {
                komanda.CommandText = String.Format("insert into Mesto values({0},'{1}')", m.PttBroj, m.Naziv);
                komanda.CommandType = CommandType.Text;
                konekcija.Open();
                return komanda.ExecuteNonQuery();

            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }

            }
        }

        public List<Ucenik> VratiSveUcenike()
        {
            List<Ucenik> ucenik = new List<Ucenik>();
            try
            {
                komanda.CommandText = "select Ucenik.Jmbg,Ucenik.Ime,Ucenik.Prezime,Odeljenje.Id_odeljenja, Mesto.Naziv, Mesto.PttBroj from(Ucenik  inner join Mesto on Ucenik.Mesto=Mesto.PttBroj)inner join Odeljenje on Ucenik.Odeljenje=Odeljenje.Id_odeljenja";
                komanda.CommandType = CommandType.Text;
                konekcija.Open();
                OleDbDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    Mesto m = new Mesto
                    {
                        PttBroj = (int)citac["pttbroj"],
                        Naziv = citac["naziv"].ToString()
                    };
                    Odeljenje o = new Odeljenje
                    {
                        Id_odeljenja = citac["Id_odeljenja"].ToString(),
                        Razredni = citac["Razredni"].ToString(),
                        Smer = citac["Smer"].ToString()
                    };
                    Ucenik  u = new Ucenik
                    {
                        Jmbg = (int)citac["Jmbg"],
                        Ime = citac["Ime"].ToString(),
                        Prezime = citac["Prezime"].ToString()
                    };
                    u.Mesto = m;
                    u.Odeljenje = o;
                    ucenik.Add(u);

                }
                return ucenik;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();

                }

            }
        }
        public int UbaciUcenika_uBazu(Ucenik u)
        {
            try
            {
                komanda.CommandText = String.Format("insert into Ucenik values({0},'{1}','{2}',{3},'{4}')", u.Jmbg, u.Ime, u.Prezime,u.Mesto.PttBroj,u.Odeljenje.Id_odeljenja);
                komanda.CommandType = CommandType.Text;
                konekcija.Open();
                return komanda.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (konekcija != null)
                {
                    konekcija.Close();
                }

            }
        }


    }
}
