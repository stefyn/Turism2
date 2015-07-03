using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turism
{
    public class Class1
    {
        static void Main(String[] args)
        {
            using (var db = new TurismBD())
            {
                string caseSwitch;
                Console.Write("Meniu nostru este:\n");
                Console.Write("1.Clienti\n");
                Console.Write("2.Oferte\n");
                Console.Write("3.Comenzi\n");
                Console.Write("4.Rapoarte\n");
                Console.WriteLine("Introduceti nr:");
                caseSwitch = Console.ReadLine();
                string alegere1;
                int al1;
                string alegere2;
                int al2;
                string alegere3;
                int al3;

                switch (caseSwitch)
                {
                    case "1":
                        {
                            Console.WriteLine(" 1. Adaugare client");
                            Console.WriteLine(" 2. Modificare informatii client");
                            Console.WriteLine(" 3. Stergere client");
                            Console.WriteLine("Introduceti nr:");
                            alegere1 = Console.ReadLine();
                            al1 = Int32.Parse(alegere1);


                            if (al1 == 1)
                            {
                                Console.Write("Nume: ");
                                var nume = Console.ReadLine();
                                Console.Write("Prenume: ");
                                var prenume = Console.ReadLine();
                                Console.WriteLine("CNP");
                                var cnp = Console.ReadLine();
                                Console.WriteLine("Email:");
                                var email = Console.ReadLine();

                                var addclient = new Client { Nume = nume, Prenume = prenume, CNP = cnp, Email = email };
                                db.Clients.Add(addclient);
                                db.SaveChanges();

                                var query = from b in db.Clients
                                            orderby b.Nume
                                            select b;

                                Console.WriteLine("All clients in the database:");
                                foreach (var item in query)
                                {
                                    Console.WriteLine(item.Nume);
                                }
                                Console.WriteLine("Press any key to exit...");
                                Console.ReadKey();
                            }

                            else if (al1 == 2)
                            {
                                Console.WriteLine("ID Pacient:");
                                string _idpacient = Console.ReadLine();
                                int _id = Convert.ToInt32(_idpacient);

                                var query = from c in db.Clients
                                            orderby c.Nume
                                            where c.ID == _id
                                            select c;

                                Console.Write("Nume: ");
                                var nume = Console.ReadLine();
                                Console.Write("Prenume: ");
                                var prenume = Console.ReadLine();
                                Console.WriteLine("CNP");
                                var cnp = Console.ReadLine();
                                Console.WriteLine("Email:");
                                var email = Console.ReadLine();

                                foreach (Client c in query)
                                {
                                    c.Nume = nume;
                                    c.Prenume = prenume;
                                    c.CNP = cnp;
                                    c.Email = email;
                                }

                                db.SaveChanges();


                            }
                            else if (al1 == 3)
                            {
                                Console.WriteLine("ID Pacient:");
                                string _idpacient = Console.ReadLine();
                                int _id = Convert.ToInt32(_idpacient);

                                var query = from c in db.Clients
                                            orderby c.Nume
                                            where c.ID == _id
                                            select c;

                                foreach (Client c in query)
                                {
                                    db.Clients.Remove(c);
                                }

                                db.SaveChanges();
                            }
                            else
                            {
                                Console.WriteLine("Press any key to exit...");
                                Console.ReadKey();
                            }
                        }
                        break;

                    case "2":
                        {
                            Console.WriteLine(" 1. Adaugare oferta");
                            Console.WriteLine(" 2. Modificare oferta");
                            Console.WriteLine(" 3. Stergere oferta");
                            Console.WriteLine("Introduceti nr:");
                            alegere2 = Console.ReadLine();
                            al2 = Int32.Parse(alegere2);

                            if (al2 == 1)
                            {
                                Console.Write("NrPersoane: ");
                                var nrpersoane = Console.ReadLine();
                                Console.Write("Data Inceput: ");
                                var datainceput = Console.ReadLine();
                                Console.WriteLine("Data Sfarsit");
                                var datasfarsit = Console.ReadLine();
                                Console.WriteLine("Pret:");
                                var pret = Console.ReadLine();
                                Console.WriteLine("AllInclusive:");
                                var allinclusive = Console.ReadLine();
                                Console.WriteLine("InCurs:");
                                var incurs = Console.ReadLine();

                                var addoferta = new OfertaSejur { NrPersoane = Convert.ToInt32(nrpersoane), DataInceput = Convert.ToDateTime(datainceput), DataSfarsit = Convert.ToDateTime(datasfarsit), Pret = float.Parse(pret), AllInclusive = Convert.ToBoolean(allinclusive), InCurs=Convert.ToBoolean(incurs) };
                                db.OfertaSejurs.Add(addoferta);
                                db.SaveChanges();

                                var query = from b in db.OfertaSejurs
                                            orderby b.NrPersoane
                                            select b;

                                Console.WriteLine("All oferts in the database:");
                                foreach (var item in query)
                                {
                                    Console.WriteLine(item.NrPersoane);
                                }
                                Console.WriteLine("Press any key to exit...");
                                Console.ReadKey();
                            }

                            else if (al2 == 2)
                            {
                                Console.WriteLine("ID Oferta:");
                                string _idoferta = Console.ReadLine();
                                int _id = Convert.ToInt32(_idoferta);

                                var query = from o in db.OfertaSejurs
                                            orderby o.NrPersoane
                                            where o.ID == _id && o.InCurs == false
                                            select o;

                                Console.Write("NrPersoane: ");
                                var nrpersoane = Console.ReadLine();
                                Console.Write("Data Inceput: ");
                                var datainceput = Console.ReadLine();
                                Console.WriteLine("Data Sfarsit");
                                var datasfarsit = Console.ReadLine();
                                Console.WriteLine("Pret:");
                                var pret = Console.ReadLine();
                                Console.WriteLine("AllInclusive:");
                                var allinclusive = Console.ReadLine();
                                Console.WriteLine("InCurs:");
                                var incurs = Console.ReadLine();

                                foreach (OfertaSejur o in query)
                                {
                                    o.NrPersoane = Convert.ToInt32(nrpersoane);
                                    o.DataInceput = Convert.ToDateTime(datainceput);
                                    o.DataSfarsit = Convert.ToDateTime(datasfarsit);
                                    o.Pret = float.Parse(pret);
                                    o.AllInclusive = Convert.ToBoolean(allinclusive);
                                    o.InCurs = Convert.ToBoolean(incurs);
                                }

                                db.SaveChanges();

                                Console.WriteLine("Press any key to exit...");
                                Console.ReadKey();
                            }

                            else if (al2==3)
                            {
                                Console.WriteLine("ID Oferta:");
                                string _idoferta = Console.ReadLine();
                                int _id = Convert.ToInt32(_idoferta);

                                var query = from o in db.OfertaSejurs
                                            orderby o.NrPersoane
                                            where o.ID == _id && o.InCurs == false
                                            select o;

                                foreach (OfertaSejur o in query)
                                {
                                    db.OfertaSejurs.Remove(o);
                                }

                                db.SaveChanges();

                                Console.WriteLine("Press any key to exit...");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Press any key to exit...");
                                Console.ReadKey();
                            }
                            
                            }
                        break;
                    case "3":
                        {
                            Console.WriteLine(" 1. Adaugare oferta");
                            Console.WriteLine("Introduceti nr:");
                            alegere3 = Console.ReadLine();
                            al3 = Int32.Parse(alegere3);

                            if (al3 == 1)
                            {
                                Console.Write("ID Oferta: ");
                                var idoferta = Console.ReadLine();
                                Console.Write("ID Client: ");
                                var idclient = Console.ReadLine();
                                

                                var addcomanda = new Comanda { IdOferta = Convert.ToInt32(idoferta), IdClient = Convert.ToInt32(idclient) };
                                db.Comandas.Add(addcomanda);
                                db.SaveChanges();

                                var query = from com in db.Comandas
                                            orderby com.IdOferta
                                            select com;

                                Console.WriteLine("All comands in the database:");
                                foreach (var item in query)
                                {
                                    Console.WriteLine(item.IdOferta);
                                }
                                Console.WriteLine("Press any key to exit...");
                                Console.ReadKey();
                            }
                        }

                        break;

                        }

                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                
            }
        }
    }
}

