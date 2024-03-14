using Npgsql;
using System;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


public class Program
{

    public static void Main(string[] args)
    {
        string connectionString = "Host=localhost;Username=postgres;Password=JeyKe65;Database=postgres";


        Console.WriteLine("Введите 1 чтобы посмотреть таблицу с типами машин");
        Console.WriteLine("Введите 2 чтобы посмотреть таблицу с водителями и их правами");
        Console.WriteLine("Введите 3 чтобы посмотреть таблицу с машинами");
        Console.WriteLine("Введите 4 чтобы посмотреть таблицу с маршрутами");
        Console.WriteLine("Введите 5 чтобы посмотреть таблицу с рейсами");
        Console.WriteLine("Введите 0 чтобы выйти");

        int choose = Convert.ToInt32(Console.ReadLine());

        while (choose != 0)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                switch (choose)
                {
                    case 1:
                        {
                            using NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM type_car", connection);
                            using (var reader = cmd.ExecuteReader())
                            {
                                Console.WriteLine("{0,-10}{1,-20}", "id", "name");

                                while (reader.Read())
                                {
                                    Console.WriteLine("{0,-10}{1,-20}", reader["id"], reader["name"]);
                                }
                            }
                            Console.WriteLine("Если вы хотите что-то добавить в таблицу введите 1");
                            int choose1 = Convert.ToInt32(Console.ReadLine());
                            if (choose1 == 1)
                            {
                                Console.WriteLine("Введите айди для типа машины");
                                int id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите тип машины");
                                string input = Console.ReadLine();
                                using NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO type_car (id, name) VALUES (@p1, @p2)", connection);
                                {
                                    command.Parameters.AddWithValue("p1", id);
                                    command.Parameters.AddWithValue("p2", input);
                                };
                                command.ExecuteNonQuery();
                                using (var reader = cmd.ExecuteReader())
                                {
                                    Console.WriteLine("{0,-10}{1,-20}", "id", "name");

                                    while (reader.Read())
                                    {
                                        Console.WriteLine("{0,-10}{1,-20}", reader["id"], reader["name"]);
                                    }
                                }
                            }

                        }
                        break;
                    case 3:
                        {
                            using NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM car", connection);
                            using (var reader = cmd.ExecuteReader())
                            {
                                Console.WriteLine("{0,-10}{1,-20}{2,-20}{3,-20}{4, -30}", "id", "id_type_car", "name", "state_number", "number_passengers");

                                while (reader.Read())
                                {
                                    Console.WriteLine("{0,-10}{1,-20}{2,-20}{3,-20}{4, -30}", reader["id"], reader["id_type_car"], reader["name"], reader["state_number"], reader["number_passengers"]);
                                }
                            }
                            Console.WriteLine("Если вы хотите что-то добавить в таблицу введите 1");
                            int choose1 = Convert.ToInt32(Console.ReadLine());
                            if (choose1 == 1)
                            {
                                Console.WriteLine("Введите айди");
                                int id = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Введите айди типа машины");
                                int id_type_car = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Введите название машины");
                                string name = Console.ReadLine();

                                Console.WriteLine("Введите номер машины");
                                string state_number = Console.ReadLine();

                                Console.WriteLine("Введите количество пассажиров");
                                int number_passengers = Convert.ToInt32(Console.ReadLine());
                                using NpgsqlCommand command = new NpgsqlCommand("INSERT INTO car (id, id_type_car, name, state_number, number_passengers) VALUES (@p1, @p2, @p3, @p4, @p5)", connection);
                                {
                                    command.Parameters.AddWithValue("p1", id);
                                    command.Parameters.AddWithValue("p2", id_type_car);
                                    command.Parameters.AddWithValue("p3", name);
                                    command.Parameters.AddWithValue("p4", state_number);
                                    command.Parameters.AddWithValue("p5", number_passengers);
                                };
                                command.ExecuteNonQuery();

                                using (var reader = cmd.ExecuteReader())
                                {
                                    Console.WriteLine("{0,-10}{1,-20}{2,-20}{3,-20}{4, -30}", "id", "id_type_car", "name", "state_number", "number_passengers");

                                    while (reader.Read())
                                    {
                                        Console.WriteLine("{0,-10}{1,-20}{2,-20}{3,-20}{4, -30}", reader["id"], reader["id_type_car"], reader["name"], reader["state_number"], reader["number_passengers"]);
                                    }
                                }

                            }
                        }
                        break;
                    case 2:
                        {
                            using NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM driver", connection);
                            using (var reader = cmd.ExecuteReader())
                            {
                                Console.WriteLine("Таблица с водителями");
                                Console.WriteLine("{0,-10}{1,-20}{2,-20}{3,-20}", "id", "first_name", "last_name", "birthdate");

                                while (reader.Read())
                                {
                                    Console.WriteLine("{0,-10}{1,-20}{2,-20}{3,-20}", reader["id"], reader["first_name"], reader["last_name"], reader["birthdate"]);
                                }
                            }
                            Console.WriteLine();
                            using NpgsqlCommand cmd1 = new NpgsqlCommand($"SELECT * FROM rights_category", connection);
                            using (var reader = cmd1.ExecuteReader())
                            {
                                Console.WriteLine("Таблица с категорией прав");
                                Console.WriteLine("{0,-10}{1,-20}", "id", "name");

                                while (reader.Read())
                                {
                                    Console.WriteLine("{0,-10}{1,-20}", reader["id"], reader["name"]);
                                }
                            }
                            Console.WriteLine();
                            using NpgsqlCommand cmd2 = new NpgsqlCommand($"SELECT * FROM driver_rights_category", connection);
                            using (var reader = cmd2.ExecuteReader())
                            {
                                Console.WriteLine("Таблица с водителями и их категорией прав");
                                Console.WriteLine("{0,-10}{1,-20}", "id_driver", "id_rights_category");

                                while (reader.Read())
                                {
                                    Console.WriteLine("{0,-10}{1,-20}", reader["id_driver"], reader["id_rights_category"]);
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("Если хотите что-то добавить в таблицы то введите ");
                            Console.WriteLine("1 если хотите добавить что-то в таблицу с водителями ");
                            Console.WriteLine("2 если хотите добавить что-то в таблицу с категорией водительских прав");
                            Console.WriteLine("3 если хотите добавить что-то в таблицу с водитедлями и категорией водительских прав");
                            Console.WriteLine("Если вы хотите вывести права определенного водителя введите 4");

                            int choose1 = Convert.ToInt32(Console.ReadLine());
                            while (choose1 != 0)
                            {

                                if (choose1 == 1)
                                {
                                    Console.WriteLine("Введите айди");
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Введите имя");
                                    string first_name = Console.ReadLine();
                                    Console.WriteLine("Введите фамилию");
                                    string last_name = Console.ReadLine();
                                    Console.WriteLine("Введите дату рождения (ДД:ММ:ГГГГ)");
                                    DateTime birthdate = Convert.ToDateTime(Console.ReadLine());
                                    using NpgsqlCommand command = new NpgsqlCommand("INSERT INTO driver (id, first_name, last_name, birthdate) VALUES (@p1, @p2, @p3, @p4)", connection);
                                    {
                                        command.Parameters.AddWithValue("p1", id);
                                        command.Parameters.AddWithValue("p2", first_name);
                                        command.Parameters.AddWithValue("p3", last_name);
                                        command.Parameters.AddWithValue("p4", birthdate);
                                    }
                                    command.ExecuteNonQuery();

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        Console.WriteLine("Таблица с водителями");
                                        Console.WriteLine("{0,-10}{1,-20}{2,-20}{3,-20}", "id", "first_name", "last_name", "birthdate");

                                        while (reader.Read())
                                        {
                                            Console.WriteLine("{0,-10}{1,-20}{2,-20}{3,-20}", reader["id"], reader["first_name"], reader["last_name"], reader["birthdate"]);
                                        }
                                    }
                                }

                                else if (choose1 == 2)
                                {
                                    Console.WriteLine("Введите айди");
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Введите наименование категории");
                                    char name = Convert.ToChar(Console.ReadLine());
                                    using NpgsqlCommand command = new NpgsqlCommand("INSERT INTO rights_category (id, name) VALUES (@p1, @p2)", connection);
                                    {
                                        command.Parameters.AddWithValue("p1", id);
                                        command.Parameters.AddWithValue("p2", name);
                                    };
                                    command.ExecuteNonQuery();

                                    using (var reader = cmd1.ExecuteReader())
                                    {
                                        Console.WriteLine("Таблица с категорией прав");
                                        Console.WriteLine("{0,-10}{1,-20}", "id", "name");

                                        while (reader.Read())
                                        {
                                            Console.WriteLine("{0,-10}{1,-20}", reader["id"], reader["name"]);
                                        }
                                    }
                                }

                                else if (choose1 == 3)
                                {
                                    Console.WriteLine("Введите айди водителя");
                                    int id_driver = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Введите айди категории водительских прав");
                                    int id_rights_category = Convert.ToInt32(Console.ReadLine());
                                    using NpgsqlCommand command = new NpgsqlCommand("INSERT INTO driver_rights_category (id_driver, id_rights_category) VALUES (@p1, @p2)", connection);
                                    {
                                        command.Parameters.AddWithValue("p1", id_driver);
                                        command.Parameters.AddWithValue("p2", id_rights_category);
                                    };
                                    command.ExecuteNonQuery();

                                    using (var reader = cmd2.ExecuteReader())
                                    {
                                        Console.WriteLine("Таблица с водителями и их категорией прав");
                                        Console.WriteLine("{0,-10}{1,-20}", "id_driver", "id_rights_category");

                                        while (reader.Read())
                                        {
                                            Console.WriteLine("{0,-10}{1,-20}", reader["id_driver"], reader["id_rights_category"]);
                                        }
                                    }

                                }


                                else if (choose1 == 4)
                                {
                                    Console.WriteLine("Введите айди водителя");
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    using NpgsqlCommand command1 = new NpgsqlCommand($"SELECT driver_rights_category.id_driver, driver.first_name, driver.last_name, rights_category.name FROM driver_rights_category INNER JOIN driver on driver_rights_category.id_driver = driver.id INNER JOIN rights_category on rights_category.id = driver_rights_category.id_rights_category WHERE driver.id = @driver_id", connection);
                                    {
                                        command1.Parameters.AddWithValue("driver_id", id);
                                    };
                                    using (var reader = command1.ExecuteReader())
                                    {
                                        Console.WriteLine("Таблица с водителями и их категорией прав");
                                        Console.WriteLine("{0, -10}{1, -20}{2, -20}{3, -20}", "id_driver", "first_name", "last_name", "name");

                                        while (reader.Read())
                                        {
                                            Console.WriteLine("{0, -10}{1, -20}{2, -20}{3, -20}", reader["id_driver"], reader["first_name"], reader["last_name"], reader["name"]);
                                        }
                                    }
                                }
                                
                                Console.WriteLine("Если хотите что-то добавить в таблицы то введите ");
                                Console.WriteLine("1если хотите добавить что-то в таблицу с водителями ");
                                Console.WriteLine("2 если хотите добавить что-то в таблицу с категорией водительских прав");
                                Console.WriteLine("3 если хотите добавить что-то в таблицу с водитедлями и категорией водительских прав");
                                Console.WriteLine("Если вы хотите вывести права определенного водителя введите 4");
                                Console.WriteLine("0 если хоиите выйти");
                                choose1 = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        break;
                    case 4:
                        {
                            using NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM itinerary", connection);
                            using (var reader = cmd.ExecuteReader())
                            {
                                Console.WriteLine("{0,-10}{1,-20}", "id", "name");

                                while (reader.Read())
                                {
                                    Console.WriteLine("{0,-10}{1,-20}", reader["id"], reader["name"]);
                                }
                            }
                            Console.WriteLine("Если вы хотите что-то добавить в таблицу введите 1");
                            int choose1 = Convert.ToInt32(Console.ReadLine());
                            if (choose1 == 1)
                            {
                                Console.WriteLine("Введите айди");
                                int id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите назание");
                                string name = Console.ReadLine();
                                using NpgsqlCommand command = new NpgsqlCommand("INSERT INTO itinerary (id, name) VALUES (@p1, @p2)", connection);
                                {
                                    command.Parameters.AddWithValue("p1", id);
                                    command.Parameters.AddWithValue("p2", name);
                                };
                                command.ExecuteNonQuery();

                                using (var reader = cmd.ExecuteReader())
                                {
                                    Console.WriteLine("{0,-10}{1,-20}", "id", "name");

                                    while (reader.Read())
                                    {
                                        Console.WriteLine("{0,-10}{1,-20}", reader["id"], reader["name"]);
                                    }
                                }
                            }
                        }
                        break;
                    case 5:
                        {
                            using NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM route", connection);
                            using (var reader = cmd.ExecuteReader())
                            {
                                Console.WriteLine("{0,-10}{1,-20}{2, -20}{3, -20}{4, -20}", "id", "id_driver", "id_car", "id_itinerary", "number_passengers");

                                while (reader.Read())
                                {
                                    Console.WriteLine("{0,-10}{1,-20}{2, -20}{3, -20}{4, -20}", reader["id"], reader["id_driver"], reader["id_car"], reader["id_itinerary"], reader["number_passengers"]);

                                }
                            }
                            Console.WriteLine("Если хотите добавить что-то в таблицу введите 1");
                            int choose1 = Convert.ToInt32(Console.ReadLine());
                            if(choose1 == 1)
                            {
                                Console.WriteLine("Введите айди");
                                int id = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Введите айди водителя");
                                int id_driver = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Введите айди машины");
                                int id_car = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Введите айди маршрута");
                                int id_itinerary = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Введите айди количество пассажиров");
                                int number_passengers = Convert.ToInt32(Console.ReadLine());

                                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO route (id, id_driver, id_car, id_itinerary, number_passengers) VALUES (@p1, @p2, @p3, @p4, @p5)", connection);
                                {
                                    command.Parameters.AddWithValue("p1", id);
                                    command.Parameters.AddWithValue("p2", id_driver);
                                    command.Parameters.AddWithValue("p3", id_car);
                                    command.Parameters.AddWithValue("p4", id_itinerary);
                                    command.Parameters.AddWithValue("p5", number_passengers);
                                };
                                command.ExecuteNonQuery();

                                using (var reader = cmd.ExecuteReader())
                                {
                                    Console.WriteLine("{0,-10}{1,-20}{2, -20}{3, -20}{4, -20}", "id", "id_driver", "id_car", "id_itinerary", "number_passengers");

                                    while (reader.Read())
                                    {
                                        Console.WriteLine("{0,-10}{1,-20}{2, -20}{3, -20}{4, -20}", reader["id"], reader["id_driver"], reader["id_car"], reader["id_itinerary"], reader["number_passengers"]);

                                    }
                                }

                            }

                        }
                        break;
                }
                Console.WriteLine("Введите 1 чтобы посмотреть таблицу с типами машин");
                Console.WriteLine("Введите 2 чтобы посмотреть таблицу с водителями и их правами");
                Console.WriteLine("Введите 3 чтобы посмотреть таблицу с машинами");
                Console.WriteLine("Введите 4 чтобы посмотреть таблицу с маршрутами");
                Console.WriteLine("Введите 5 чтобы посмотреть таблицу с рейсами");
                Console.WriteLine("Введите 0 чтобы выйти");
                choose = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}