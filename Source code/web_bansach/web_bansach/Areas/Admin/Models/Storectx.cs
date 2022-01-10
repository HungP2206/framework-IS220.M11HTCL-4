using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using web_bansach.Models;

namespace web_bansach.Areas.Admin.Models
{
    public class Storectx
    {
        public string ConnectionString { get; set; }
        public Storectx(string connectinstring)
        {
            this.ConnectionString = connectinstring;
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }


        //============================================================
        //=========================   AUTHOR   =======================
        //============================================================
        public int InsertAuthor(AuthorModel a)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "insert into Author( AuthorName, Email, Phone, Gender, AuthorStatus, Created_at) " +
                          "values( @AuthorName, @Email, @Phone, @Gender, @AuthorStatus, @Created_at)";
                SqlCommand cmd = new SqlCommand(sql, conn);
               
                cmd.Parameters.AddWithValue("AuthorName", a.AuthorName);
                cmd.Parameters.AddWithValue("Email", a.Email);
                cmd.Parameters.AddWithValue("Phone", a.Phone);
                cmd.Parameters.AddWithValue("Gender", a.Gender);
                cmd.Parameters.AddWithValue("AuthorStatus", a.AuthorStatus);
                cmd.Parameters.AddWithValue("Created_at", a.Created_at);
                return (cmd.ExecuteNonQuery());
            }
        }

        // liet ke tacgia
        public List<AuthorModel> sqlListtacgia()
        {
            List<AuthorModel> list = new List<AuthorModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT * FROM Author ";
                SqlCommand cmd = new SqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new AuthorModel
                        {
                            //reader đọc trong sql
                            AuthorID = Convert.ToInt32(reader["AuthorID"]),
                            AuthorName = reader["AuthorName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Gender = (byte)Convert.ToInt32(reader["Gender"]),
                            AuthorStatus = (byte)Convert.ToInt32(reader["AuthorStatus"]),
                            //Trash = (byte)Convert.ToInt32(reader["Trash"]),
                            //Created_at = reader.GetDateTime(reader.GetOrdinal("Created_at"))
                            Created_at = Convert.ToDateTime(reader["Created_at"].ToString())
                        }) ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        //xem chi tiet tac gia
        public AuthorModel viewAuthor(int id, string name)
        {
            AuthorModel a = new AuthorModel();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "SELECT * FROM Author WHERE AuthorID = @idtg and AuthorName = @nametg";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("idtg", id);
                cmd.Parameters.AddWithValue("nametg", name);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    a.AuthorID = Convert.ToInt32(reader["AuthorID"]);
                    a.AuthorName = reader["AuthorName"].ToString();
                    a.Email = reader["Email"].ToString();
                    a.Phone = reader["Phone"].ToString();
                    a.Gender = (byte)Convert.ToInt32(reader["Gender"]);
                    a.AuthorStatus = (byte)Convert.ToInt32(reader["AuthorStatus"]);
                }
                conn.Close();
            }
            return (a);
        }

        // xoa tac gia
        public int XoaAuthor(int id)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from Author where AuthorID = @AuthorID";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("AuthorID", id);
                return (cmd.ExecuteNonQuery());
            }
        }

        //cap nhat tac gia
        public int updateAuthor(AuthorModel a)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update Author   " +
                           "set  AuthorName = @AuthorName, " +
                           " Phone = @Phone, " +
                           " Email = @Email,  " +
                           " Gender = @Gender, " +
                           " AuthorStatus = @AuthorStatus " +
                           "where AuthorID = @AuthorID";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("AuthorID", a.AuthorID);
                cmd.Parameters.AddWithValue("AuthorName", a.AuthorName);
                cmd.Parameters.AddWithValue("Phone", a.Phone);
                cmd.Parameters.AddWithValue("Email", a.Email);
                cmd.Parameters.AddWithValue("Gender", a.Gender);
                cmd.Parameters.AddWithValue("AuthorStatus", a.AuthorStatus);


                return (cmd.ExecuteNonQuery());

            }
        }

        // search tac gia 
        public List<AuthorModel> searchAuthor(string searchString)
        {
            List<AuthorModel> list = new List<AuthorModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from Author   " +
                              "where AuthorID like  '%' + @input + '%' " +
                              "or AuthorName like  '%' +  @input + '%' " +
                              "or Email like   '%' + @input + '%' " +
                              "or Phone like   '%' + @input + '%' ";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("input", searchString);      
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new AuthorModel
                        {
                            AuthorID = Convert.ToInt32(reader["AuthorID"]) ,
                            AuthorName = reader["AuthorName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Gender = (byte)Convert.ToInt32(reader["Gender"]),
                            AuthorStatus = (byte)Convert.ToInt32(reader["AuthorStatus"]),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        //============================================================
        //=========================   CATEGORY   =====================
        //============================================================

        // them danh muc Category
        public int InsertCategory(CategoryModel c)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "insert into Category(CategoryName, Created_at , CategoryStatus ) " +
                          "values( @CategoryName,  @Created_at, @CategoryStatus)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("CategoryName", c.CategoryName);
                cmd.Parameters.AddWithValue("Created_at", c.Created_at);
                cmd.Parameters.AddWithValue("CategoryStatus", c.CategoryStatus);
                return (cmd.ExecuteNonQuery());
            }
        }

        //// liet ke danh muc
        //// sqlListCate
        public List<CategoryModel> sqlListCate()
        {
            List<CategoryModel> list = new List<CategoryModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT * FROM Category ";
                SqlCommand cmd = new SqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CategoryModel
                        {
                            //reader đọc trong sql
                            CategoryID = Convert.ToInt32(reader["CategoryID"]),
                            CategoryName = reader["CategoryName"].ToString(),
                            //ParentID = Convert.ToInt32(reader["CategoryID"]),
                            CategoryStatus = (byte)Convert.ToInt32(reader["CategoryStatus"]),
                            Created_at = Convert.ToDateTime(reader["Created_at"].ToString())
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        ////Xoa Category
        public int XoaCategory(int id)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from Category where CategoryID = @CategoryID";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("CategoryID", id);
                return (cmd.ExecuteNonQuery());
            }
        }


        //view Category
        public CategoryModel viewCategory(int id)
        {
            CategoryModel c = new CategoryModel();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "SELECT * FROM Category WHERE CategoryID = @idcate ";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("idcate", id);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    c.CategoryID = Convert.ToInt32(reader["CategoryID"]);
                    c.CategoryName = reader["CategoryName"].ToString();
                    c.CategoryStatus = (byte)Convert.ToInt32(reader["CategoryStatus"]);
                }
                conn.Close();
            }
            return (c);
        }

        //capnhat category
        public int capnhatCategory(CategoryModel c)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update Category   " +
                           "set  CategoryName = @CategoryName,  " +
                           "CategoryStatus = @CategoryStatus  " +
                           "where CategoryID = @CategoryID";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("CategoryID", c.CategoryID);
                cmd.Parameters.AddWithValue("CategoryName", c.CategoryName);
                cmd.Parameters.AddWithValue("CategoryStatus", c.CategoryStatus);
                return (cmd.ExecuteNonQuery());

            }
        }

        //tim kiem  Category
        public List<CategoryModel> searchCategory(string searchString)
        {
            List<CategoryModel> list = new List<CategoryModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from Category   " +
                              "where CategoryID like  '%' + @input + '%' " +
                              "or CategoryName like  '%' +  @input + '%' ";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("input", searchString);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CategoryModel
                        {
                            CategoryID = Convert.ToInt32(reader["CategoryID"]),
                            CategoryName = reader["CategoryName"].ToString(),
                            CategoryStatus = (byte)Convert.ToInt32(reader["CategoryStatus"]),
                            Created_at = Convert.ToDateTime(reader["Created_at"].ToString())
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }



        //============================================================
        //=========================   PRODUCER   =====================
        //============================================================

        //them producer
        public int InsertProducer(ProducerModel p)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "insert into Producer( ProducerName, Created_at, ProducerStatus ) " +
                          "values( @ProducerName, @Created_at, @ProducerStatus)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("ProducerName", p.ProducerName);
                cmd.Parameters.AddWithValue("Created_at", p.Created_at);
                cmd.Parameters.AddWithValue("ProducerStatus", p.ProducerStatus);
                return (cmd.ExecuteNonQuery());
            }
        }

        // liet ke producer
        public List<ProducerModel> sqlListncc()
        {
            List<ProducerModel> list = new List<ProducerModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT * FROM Producer ";
                SqlCommand cmd = new SqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ProducerModel
                        {
                            ProducerID = Convert.ToInt32(reader["ProducerID"]),
                            ProducerName = reader["ProducerName"].ToString(),
                            ProducerStatus = (byte)Convert.ToInt32(reader["ProducerStatus"]),
                            Created_at = Convert.ToDateTime(reader["Created_at"].ToString())
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        //Xoa Producer
        public int XoaProducer(int id)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from Producer where ProducerID = @ProducerID";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ProducerID", id);
                return (cmd.ExecuteNonQuery());
            }
        }


        //view Producer
        public ProducerModel viewProducer(int id)
        {
            ProducerModel p = new ProducerModel();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "SELECT * FROM Producer WHERE ProducerID = @idPro ";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("idPro", id);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    p.ProducerID = Convert.ToInt32(reader["ProducerID"]);
                    p.ProducerName = reader["ProducerName"].ToString();
                    p.ProducerStatus = (byte)Convert.ToInt32(reader["ProducerStatus"]);
                }
                conn.Close();
            }
            return (p);
        }

        //capnhat Producer
        public int capnhatProducer(ProducerModel c)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update Producer  " +
                           "set  ProducerName = @ProducerName,  " +
                           "ProducerStatus = @ProducerStatus  " +
                           "where ProducerID = @ProducerID";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ProducerID", c.ProducerID);
                cmd.Parameters.AddWithValue("ProducerName", c.ProducerName);
                cmd.Parameters.AddWithValue("ProducerStatus", c.ProducerStatus);
                return (cmd.ExecuteNonQuery());

            }
        }

        //tim kiem Producer
        public List<ProducerModel> searchProducer(string searchString)
        {
            List<ProducerModel> list = new List<ProducerModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from Producer   " +
                              "where ProducerID like  '%' + @input + '%' " +
                              "or ProducerName like  '%' +  @input + '%' ";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("input", searchString);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ProducerModel
                        {
                            ProducerID = Convert.ToInt32(reader["ProducerID"]),
                            ProducerName = reader["ProducerName"].ToString(),
                            ProducerStatus = (byte)Convert.ToInt32(reader["ProducerStatus"]),
                            Created_at = Convert.ToDateTime(reader["Created_at"].ToString())
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }



        //============================================================
        //=========================   USER   =========================
        //============================================================
        public int InsertUser(UserModel u)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "insert into db_User(EmployeeName, Gender, Phone, Email, Address, Created_at, UserStatus)" +
                          "values (@EmployeeName, @Gender, @Phone, @Email, @Address, @Created_at, @UserStatus)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("EmployeeName", u.EmployeeName);
                //cmd.Parameters.AddWithValue("UserName", u.UserName);
                //cmd.Parameters.AddWithValue("Password", u.Password);
                cmd.Parameters.AddWithValue("Gender", u.Gender);
                cmd.Parameters.AddWithValue("Phone", u.Phone);
                cmd.Parameters.AddWithValue("Email", u.Email);
                cmd.Parameters.AddWithValue("Address", u.Address);
                cmd.Parameters.AddWithValue("Created_at", u.Created_at);
                cmd.Parameters.AddWithValue("UserStatus", u.UserStatus);
                return (cmd.ExecuteNonQuery());
            }
        }

        // liet ke User
        public List<UserModel> sqlListUser()
        {
            List<UserModel> list = new List<UserModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT * FROM db_User ";
                SqlCommand cmd = new SqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new UserModel
                        {
                            UserID = Convert.ToInt32(reader["UserID"]),
                            EmployeeName = reader["EmployeeName"].ToString(),
                            UserName = reader["UserName"].ToString(),
                            Password = reader["Password"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Gender = (byte)Convert.ToInt32(reader["Gender"]),
                            Address = reader["Address"].ToString(),
                            UserStatus = (byte)Convert.ToInt32(reader["UserStatus"]),
                            Created_at = Convert.ToDateTime(reader["Created_at"].ToString())
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        //Xoa User
        public int XoaUser(int id)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from db_User where UserID = @UserID";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("UserID", id);
                return (cmd.ExecuteNonQuery());
            }
        }

        //view User
        public UserModel viewUser(int id)
        {
            UserModel p = new UserModel();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "SELECT * FROM db_User WHERE UserID = @idU ";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("idU", id);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    p.UserID = Convert.ToInt32(reader["UserID"]);
                    p.EmployeeName = reader["EmployeeName"].ToString();
                   // p.UserName = reader["UserName"].ToString();
                   // p.Password = reader["Password"].ToString();
                    p.Email = reader["Email"].ToString();
                    p.Phone = reader["Phone"].ToString();
                    p.Address = reader["Address"].ToString();
                    p.Gender = (byte)Convert.ToInt32(reader["Gender"]);
                    p.UserStatus = (byte)Convert.ToInt32(reader["UserStatus"]);
                }
                conn.Close();
            }
            return (p);
        }

        // lock user
        public int lockND(int id)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update db_User " +
                           "set UserStatus = 1 " + //
                           "where UserID = @UID";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("UID", id);

                return (cmd.ExecuteNonQuery());
            }
        }
        // unlock user
        public int unlockND(int id)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update db_User " +
                           "set UserStatus = 0  " + //
                           "where UserID = @UID";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("UID", id);

                return (cmd.ExecuteNonQuery());
            }
        }


        //capnhat User
        public int capnhatUser(UserModel u)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update db_User  set " +
                           "EmployeeName = @EmployeeName, " +
                           //"UserName = @UserName,  " +
                           //"Password = @Password,  " +
                           "Phone = @Phone, " +
                           "Email = @Email,  " +
                           "Gender = @Gender, " +
                           "Address = @Address, " +
                           "UserStatus = @UserStatus  " +
                           "where UserID = @UserID";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("UserID", u.UserID);
                cmd.Parameters.AddWithValue("EmployeeName", u.EmployeeName);
                //cmd.Parameters.AddWithValue("UserName", u.UserName);
                //cmd.Parameters.AddWithValue("Password", u.Password);
                cmd.Parameters.AddWithValue("Phone", u.Phone);
                cmd.Parameters.AddWithValue("Email", u.Email);
                cmd.Parameters.AddWithValue("Gender", u.Gender);
                cmd.Parameters.AddWithValue("Address", u.Address);
                cmd.Parameters.AddWithValue("UserStatus", u.UserStatus);
                return (cmd.ExecuteNonQuery());

            }
        }

        //tim kiem user
        public List<UserModel> searchUser(string searchString)
        {
            List<UserModel> list = new List<UserModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from db_User   " +
                              "where UserID like  '%' + @input + '%' " +
                              "or UserName like  '%' +  @input + '%' " +
                              "or Phone like  '%' +  @input + '%' " +
                              "or Email like  '%' +  @input + '%' " +
                              "or EmployeeName like  '%' +  @input + '%' ";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("input", searchString);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new UserModel
                        {
                            UserID = Convert.ToInt32(reader["UserID"]),
                            UserName = reader["UserName"].ToString(),
                            Password = reader["Password"].ToString(),
                            EmployeeName = reader["EmployeeName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Address = reader["Address"].ToString(),
                            Created_at = Convert.ToDateTime(reader["Created_at"].ToString()),
                            Gender = (byte)Convert.ToInt32(reader["Gender"]),
                            UserStatus = (byte)Convert.ToInt32(reader["UserStatus"]),

                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        
        //============================================================
        //=========================   CUSTOMER   =====================
        //============================================================

        // liet ke KH
        public List<CustomerModel> sqlListKH()
        {
            List<CustomerModel> list = new List<CustomerModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT * FROM Customer ";
                SqlCommand cmd = new SqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CustomerModel
                        {
                            CustomerID = Convert.ToInt32(reader["CustomerID"]),
                            CustomerName = reader["CustomerName"].ToString(),
                            Email = reader["Email"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            // = (byte)Convert.ToInt32(reader["Gender"]),
                            UserName = reader["UserName"].ToString(),
                            Password = reader["Password"].ToString(),
                            Address = reader["Address"].ToString(),
                            CustomerStatus = (byte)Convert.ToInt32(reader["CustomerStatus"]),
                            //Created_at = Convert.ToDateTime(reader["Created_at"].ToString())
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        //xoa KH
        public int XoaKH(int id)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from Customer where CustomerID = @CustomerID";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("CustomerID", id);
                return (cmd.ExecuteNonQuery());
            }
        }

        // search KH
        public List<CustomerModel> searchKH(string searchString)
        {
            List<CustomerModel> list = new List<CustomerModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from Customer   " +
                              "where CustomerID like  '%' + @input + '%' " +
                              "or CustomerName like  '%' +  @input + '%' " +
                              "or Email like   '%' + @input + '%' " +
                              "or Phone like   '%' + @input + '%' ";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("input", searchString);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CustomerModel
                        {
                            CustomerID = Convert.ToInt32(reader["CustomerID"]),
                            CustomerName = reader["CustomerName"].ToString(),
                            Email = reader["Email"].ToString(),
                            PhoneNumber = reader["Phone"].ToString(),
                            Gender = (byte)Convert.ToInt32(reader["Gender"]),
                            UserName = reader["UserName"].ToString(),
                            Password = reader["Password"].ToString(),
                            Address = reader["Address"].ToString(),
                            CustomerStatus = (byte)Convert.ToInt32(reader["CustomerStatus"]),
                            Created_at = Convert.ToDateTime(reader["Created_at"].ToString())

                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        //lock KH
        public int lockKH(int id)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update Customer " +
                           "set CustomerStatus = 1 " + //
                           "where CustomerID = @CusID";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("CusID", id);

                return (cmd.ExecuteNonQuery());
            }
        }

        //unlock KH
        public int unlockKH(int id)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update Customer " +
                           "set CustomerStatus = 0  " + //
                           "where CustomerID = @CusID";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("CusID", id);

                return (cmd.ExecuteNonQuery());
            }
        }

        // mail KH
        public List<object> ListEmailCustomer()
        {
            List<object> list = new List<object>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT Email FROM Customer ";
                SqlCommand cmd = new SqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new 
                        {
                            Email = reader["Email"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }


        //============================================================
        //=========================   ORDER   ========================
        //============================================================

        // xem donhang
        public List<object> sqlListOrder()
        {
            List<object> list = new List<object>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = @"select distinct O.OrderID, C.CustomerName, C.PhoneNumber,  Total, O.Created_at, OrderStatus
                               from  Orderdetail OD, db_Order O, Customer C
                               where OD.OrderID = O.OrderID and C.CustomerID = O.CustomerID  ";
                SqlCommand cmd = new SqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            OrderID = reader["OrderID"].ToString(),
                            CustomerName = reader["CustomerName"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            OrderStatus = Convert.ToInt32(reader["OrderStatus"]),
                            Created_at = Convert.ToDateTime(reader["Created_at"].ToString()),
                            Total = Convert.ToDouble(reader["Total"]).ToString("0,0 đ")
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        // xem chi tiet donhang
        public List<object> sqlListDetailOrder(int id)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            List<object> list = new List<object>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = @"select O.OrderID, C.CustomerName, BookName, OD.PriceUnit, OD.Quantity , O.Created_at,  OrderStatus,
                                      OD.Sale*100 Sale, OD.PriceUnit*(1-OD.Sale) PriceSale, C.Address,
                                      OD.Quantity * OD.PriceUnit*(1-OD.Sale) Totalbyquantity, sum(total) TOTAL
                              from  Orderdetail OD, db_Order O, Customer C , Book B
                              where OD.OrderID = O.OrderID and C.CustomerID = O.CustomerID  and B.BookID = OD.BookID  and O.OrderID = @idip
                              group by O.OrderID, C.CustomerName, BookName ,OD.PriceUnit, OD.Quantity , OD.Sale, O.Created_at,  OrderStatus, C.Address ";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("idip", id);
                using (var reader = cmd.ExecuteReader())
                {
                  
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            OrderID = reader["OrderID"].ToString(),
                            CustomerName = reader["CustomerName"].ToString(),
                            BookName = reader["BookName"].ToString(),
                            Address = reader["Address"].ToString(),

                            PriceUnit = String.Format(culture, "{0:N0}", (reader["PriceUnit"])),

                            //PriceUnit = Convert.ToDouble(reader["PriceUnit"]).ToString("0,0"),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            Sale = Convert.ToDouble(reader["Sale"]),
                            PriceSale = Convert.ToDouble(reader["PriceSale"]).ToString("0,0"),

                            //Totalbyquantity = Convert.ToDouble(reader["Totalbyquantity"]).ToString("0,0"),

                            Totalbyquantity = Convert.ToDouble(reader["Totalbyquantity"]).ToString(),

                            TOTAL = Convert.ToDouble(reader["TOTAL"]).ToString("0,0"),
                            OrderStatus = Convert.ToInt32(reader["OrderStatus"]),
                            Created_at = Convert.ToDateTime(reader["Created_at"].ToString()),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        //// view update donhang
        public OrderModel viewOrder(int id)
        {
            OrderModel p = new OrderModel();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "SELECT * FROM db_Order WHERE OrderID = @id ";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    p.OrderID = Convert.ToInt32(reader["OrderID"]);
                    p.OrderStatus = Convert.ToInt32(reader["OrderStatus"]);
                }
                conn.Close();
            }
            return (p);
        }


        // update status donhang
        public int updateOrder(OrderModel o)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update db_Order  set " +
                           "OrderStatus = @OrderStatus  " +
                           "where OrderID = @OrderID";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("OrderID", o.OrderID);
                cmd.Parameters.AddWithValue("OrderStatus", o.OrderStatus);
                return (cmd.ExecuteNonQuery());

            }
        }

        // search order
        public List<object> searchOrder(string searchString)
        {
            List<object> list = new List<object>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = @"select distinct O.OrderID, C.CustomerName, C.PhoneNumber,  Total, O.Created_at, OrderStatus
                               from  Orderdetail OD, db_Order O, Customer C
                               where OD.OrderID = O.OrderID and C.CustomerID = O.CustomerID and 
                                     (O.OrderID like '%' + @input + '%' 
                                     or C.CustomerName like  '%' + @input + '%' 
                                     or PhoneNumber like   '%' + @input + '%' )";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("input", searchString);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new 
                        {
                            OrderID = reader["OrderID"].ToString(),
                            CustomerName = reader["CustomerName"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            OrderStatus = Convert.ToInt32(reader["OrderStatus"]),
                            Created_at = Convert.ToDateTime(reader["Created_at"].ToString()),
                            Total = Convert.ToDouble(reader["Total"]).ToString("0,0 đ")

                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }


        // don hang homepage theo id KH
        public List<object> DetailOrderHomePage(int id)
        { 
        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
        List<object> list = new List<object>();
        using (SqlConnection conn = GetConnection())
        {
            conn.Open();
            string str = @"select O.OrderID, BookName, OD.PriceUnit, OD.Quantity , O.Created_at,  OrderStatus,
                                OD.Sale*100 Sale, OD.PriceUnit*(1-OD.Sale) PriceSale, 
                                OD.Quantity * (OD.PriceUnit*(1-OD.Sale)) Totalbyquantity,   TOTAL

                                from  Orderdetail OD, db_Order O, Customer C , Book B
                                where OD.OrderID = O.OrderID and C.CustomerID = O.CustomerID  and B.BookID = OD.BookID and C.CustomerID = @idU
                                group by O.OrderID, C.CustomerName, BookName, OD.PriceUnit, OD.Quantity , OD.Sale, O.Created_at,  OrderStatus, TOTAL ";

                SqlCommand cmd = new SqlCommand(str, conn);
            cmd.Parameters.AddWithValue("idU", id);
            using (var reader = cmd.ExecuteReader())
            {
            while (reader.Read())
            {
                list.Add(new
                {
                    OrderID = reader["OrderID"].ToString(),
                   
                    BookName = reader["BookName"].ToString(),

                    PriceUnit = String.Format(culture, "{0:N0}", (reader["PriceUnit"])),
                    //PriceUnit = Convert.ToDouble(reader["PriceUnit"]).ToString("0,0"),
                    Quantity = Convert.ToInt32(reader["Quantity"]),
                    Sale = Convert.ToDouble(reader["Sale"]),
                    PriceSale = String.Format(culture, "{0:N0}", (reader["PriceSale"])),
                    //PriceSale = Convert.ToDouble(reader["PriceSale"]).ToString("0,0"),
                    //Totalbyquantity = Convert.ToDouble(reader["Totalbyquantity"]).ToString("0,0"),

                    Totalbyquantity = Convert.ToDouble(reader["Totalbyquantity"]).ToString(),

                    TOTAL = Convert.ToDouble(reader["TOTAL"]).ToString("0,0"),

                    OrderStatus = Convert.ToInt32(reader["OrderStatus"]),
                    Created_at = Convert.ToDateTime(reader["Created_at"].ToString()),
                });
                }
                reader.Close();
            }
            conn.Close();
        }
        return list;
    }



        //============================================================
        //=========================   BOOK   =========================
        //============================================================

        // thêm sách
        public int InsertBook(BookModel a)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "insert into Book " +
                          "(BookName, AuthorID, ProducerID, CategoryID, Introduction, " +
                          "Description, PriceUnit, Sale, Quantity, Created_at, Img, BookStatus) " +
                          "values(@BookName, @AuthorID, @ProducerID, @CategoryID, @Introduction, @Description,  " +
                                 "@PriceUnit, @Sale, @Quantity, @Created_at, @Img, @BookStatus )";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("BookName", a.BookName);
                cmd.Parameters.AddWithValue("AuthorID", a.AuthorID);
                cmd.Parameters.AddWithValue("ProducerID", a.ProducerID);
                cmd.Parameters.AddWithValue("CategoryID", a.CategoryID);
                cmd.Parameters.AddWithValue("Introduction", a.Introduction);
                cmd.Parameters.AddWithValue("Description", a.Description);
                cmd.Parameters.AddWithValue("PriceUnit", a.PriceUnit);
                cmd.Parameters.AddWithValue("Sale", a.Sale);
                cmd.Parameters.AddWithValue("Quantity", a.Quantity);
               // cmd.Parameters.AddWithValue("Quantity_buy", a.QuantityBuy);
                cmd.Parameters.AddWithValue("Created_at", a.Created_at);
                cmd.Parameters.AddWithValue("Img", a.Img);
                cmd.Parameters.AddWithValue("BookStatus", a.BookStatus);
                return (cmd.ExecuteNonQuery());
            }
        }

        // liet ke sach
        public List<object> sqlListSach()
        {
            List<object> list = new List<object>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = @"select  BookID, BookName, CategoryName, Img, AuthorName,  
                                       ProducerName, Quantity, BookStatus 
                             from  Book B, Author A, Producer P, Category C
                             where  B.AuthorID = A.AuthorID and B.ProducerID = P.ProducerID and B.CategoryID = C.CategoryID";
                SqlCommand cmd = new SqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            BookID = reader["BookID"].ToString(),
                            BookName = reader["BookName"].ToString(),
                            CategoryName = reader["CategoryName"].ToString(),
                            Img = reader["Img"].ToString(),
                            AuthorName = reader["AuthorName"].ToString(),
                            ProducerName = reader["ProducerName"].ToString(),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            BookStatus = Convert.ToInt32(reader["BookStatus"]),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        // list book homepage
        public List<object> listBookHomePage()
        {
            List<object> list = new List<object>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = @"select  BookID, BookName, CategoryName, Img, AuthorName, PriceUnit, sum(PriceUnit*(1-Sale)) Total , 
                                       ProducerName, Quantity, BookStatus
                             from  Book B, Author A, Producer P, Category C
                             where  B.AuthorID = A.AuthorID and B.ProducerID = P.ProducerID and B.CategoryID = C.CategoryID
                             group by BookID, BookName, CategoryName, Img, AuthorName, PriceUnit,  
                                       ProducerName, Quantity, BookStatus";
                SqlCommand cmd = new SqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            BookID = Convert.ToInt32(reader["BookID"]),
                            BookName = reader["BookName"].ToString(),
                            CategoryName = reader["CategoryName"].ToString(),
                            Img = reader["Img"].ToString(),
                            AuthorName = reader["AuthorName"].ToString(),
                            ProducerName = reader["ProducerName"].ToString(),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            PriceUnit = Convert.ToDouble(reader["PriceUnit"]).ToString("0,0 đ"),
                            //Sale = Convert.ToDouble(reader["Sale"]),
                            Total = Convert.ToDouble(reader["Total"]).ToString("0,0 đ"),
                            BookStatus = Convert.ToInt32(reader["BookStatus"]),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        // book detail homepage
        public List<object> bookDetailHomePage(int id)
        {
            List<object> list = new List<object>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = @"select  BookID, BookName, CategoryName, Img, AuthorName, PriceUnit, sum(PriceUnit*(1-Sale)) Total , 
                                       ProducerName, Quantity, BookStatus
                             from  Book B, Author A, Producer P, Category C
                             where  B.AuthorID = A.AuthorID and B.ProducerID = P.ProducerID and 
                                    B.CategoryID = C.CategoryID and BookID = @input
                             group by BookID, BookName, CategoryName, Img, AuthorName, PriceUnit, Sale, 
                                       ProducerName, Quantity, BookStatus";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("input", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            BookID = Convert.ToInt32(reader["BookID"]),
                            BookName = reader["BookName"].ToString(),
                            CategoryName = reader["CategoryName"].ToString(),
                            Img = reader["Img"].ToString(),
                            AuthorName = reader["AuthorName"].ToString(),
                            ProducerName = reader["ProducerName"].ToString(),
                            //Introduction = Convert.ToChar(reader["Description"])
                            //Description = reader["Description"].GetHashCode(),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            PriceUnit = Convert.ToDouble(reader["PriceUnit"]).ToString("0,0 đ"),
                            //Sale = Convert.ToDouble(reader["Sale"]),
                            Total = Convert.ToDouble(reader["Total"]).ToString("0,0 đ"),
                            BookStatus = Convert.ToInt32(reader["BookStatus"]),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        // view update sach
        public List<object> bookDetailHomePage2(int id)
        {
            List<object> list = new List<object>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = @"select  BookID, BookName, Img, AuthorName, A.AuthorID, PriceUnit, sum(PriceUnit*(1-Sale)) Total , Sale,
                                       ProducerName, P.ProducerID, Quantity, BookStatus, CategoryName, C.CategoryID, Introduction, Description
                             from  Book B, Author A, Producer P, Category C
                             where  B.AuthorID = A.AuthorID and B.ProducerID = P.ProducerID and 
                                    B.CategoryID = C.CategoryID and BookID = @input
                             group by BookID, BookName, Img, AuthorName, A.AuthorID, PriceUnit , Sale,
                                       ProducerName, P.ProducerID, Quantity, BookStatus, CategoryName, C.CategoryID, Introduction, Description";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("input", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            BookID = Convert.ToInt32(reader["BookID"]),
                            BookName = reader["BookName"].ToString(),
                            CategoryName = reader["CategoryName"].ToString(),
                            CategoryID = reader["CategoryID"].ToString(),
                            Img = reader["Img"].ToString(),
                            AuthorName = reader["AuthorName"].ToString(),
                            AuthorID = reader["AuthorID"].ToString(),
                            ProducerName = reader["ProducerName"].ToString(),
                            ProducerID = reader["ProducerID"].ToString(),
                            Introduction = reader["Introduction"].ToString(),
                            Description = reader["Description"].ToString(),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            PriceUnit = Convert.ToDouble(reader["PriceUnit"]).ToString("0,0 "),
                            Sale = Convert.ToDouble(reader["Sale"]).ToString("F"),
                            Total = Convert.ToDouble(reader["Total"]).ToString("0,0 "),
                            BookStatus = Convert.ToInt32(reader["BookStatus"]),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        // tim kiem sach admin
        public List<object> searchSach(string searchString)
        {
            List<object> list = new List<object>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select BookID, BookName,CategoryName,ProducerName, Img, AuthorName, Quantity, BookStatus  " +
                             "from  Book B, Author A , Producer P, Category C  " +
                             "where  B.AuthorID = A.AuthorID and P.ProducerID = B.ProducerID " +
                                     "and C.CategoryID = B.CategoryID and " +
                                     "(BookName like  '%' + @input + '%' " +
                                     "or BookID like   '%' + @input + '%' " +
                                     "or AuthorName like  '%' +  @input + '%' " +
                                     "or CategoryName like   '%' + @input + '%' " +
                                     "or ProducerName like   '%' + @input + '%' )";


                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("input", searchString);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new 
                        {
                            BookID = reader["BookID"].ToString(),
                            BookName = reader["BookName"].ToString(),
                            CategoryName = reader["CategoryName"].ToString(),
                            Img = reader["Img"].ToString(),
                            AuthorName = reader["AuthorName"].ToString(),
                            ProducerName = reader["ProducerName"].ToString(),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            BookStatus = Convert.ToInt32(reader["BookStatus"]),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        //cap nhap sl sach
        public int tangSL(int id, int sl_old, int sl_add)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update Book " +
                           "set Quantity =  @slold + @sladd  " + //
                           "where BookID = @BID";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("slold", sl_old);
                cmd.Parameters.AddWithValue("sladd", sl_add);
                cmd.Parameters.AddWithValue("BID", id);

                return (cmd.ExecuteNonQuery());
            }
        }

        // xoa sach
        public int xoaSach(int id)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from Book where BookID = @ID";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", id);
                return (cmd.ExecuteNonQuery());
            }
        }

        //cap nhat sach
        public int updateBook(BookModel a)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update Book   " +
                           "set  BookName = @BookName, " +
                           "AuthorID = @AuthorID, " +
                           "ProducerID = @ProducerID,  " +
                           "Introduction = @Introduction, " +
                           "Description = @Description, " +
                           "CategoryID = @CategoryID, " +
                           "Quantity = @Quantity, " +
                           "PriceUnit = @PriceUnit, " +
                           "Sale = @Sale, " +
                           "BookStatus = @BookStatus " +
                           "where BookID = @BookID";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("AuthorID", a.AuthorID);
                cmd.Parameters.AddWithValue("ProducerID", a.ProducerID);
                cmd.Parameters.AddWithValue("CategoryID", a.CategoryID);
                cmd.Parameters.AddWithValue("BookID", a.BookID);
                cmd.Parameters.AddWithValue("BookName", a.BookName);
                cmd.Parameters.AddWithValue("Quantity", a.Quantity);
                // cmd.Parameters.AddWithValue("Img", a.Img);
                cmd.Parameters.AddWithValue("PriceUnit", a.PriceUnit);
                cmd.Parameters.AddWithValue("Sale", a.Sale);
                cmd.Parameters.AddWithValue("Introduction", a.Introduction);
                cmd.Parameters.AddWithValue("Description", a.Description);
                cmd.Parameters.AddWithValue("BookStatus", a.BookStatus);


                return (cmd.ExecuteNonQuery());

            }
        }

        // view cap nhat sl sach
        public BookModel viewBook(int id)
        {
            BookModel p = new BookModel();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "SELECT * FROM Book WHERE BookID = @id ";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", id);
                using (var reader = cmd.ExecuteReader())
                {

                    reader.Read();
                    p.BookID = Convert.ToInt32(reader["BookID"]);
                    p.BookName = reader["BookName"].ToString();
                    p.AuthorID = Convert.ToInt32(reader["AuthorID"]);
                    p.CategoryID = Convert.ToInt32(reader["CategoryID"]);
                    p.ProducerID = Convert.ToInt32(reader["ProducerID"]);
                    //p.Img = reader["Img"].ToString();
                    p.Quantity = Convert.ToInt32(reader["Quantity"]);
                    p.PriceUnit = Convert.ToDouble(reader["PriceUnit"]);
                    p.Sale = Convert.ToDouble(reader["Sale"]);
                    p.Introduction = reader["Introduction"].ToString();
                    p.Description = reader["Description"].ToString();
                    //p.QuantityBuy = Convert.ToInt32(reader["QuantityBuy"]);
                    p.BookStatus = (byte)Convert.ToInt32(reader["BookStatus"]);
                }
                conn.Close();
            }
            return (p);
        }

        // all book homepage
        public List<object> allBookHomePage()
        {
            List<object> list = new List<object>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = @"select  BookID, BookName, CategoryName, Img, AuthorName, PriceUnit, sum(PriceUnit*(1-Sale)) Total , 
                                       ProducerName, Quantity, BookStatus, Sale
                             from  Book B, Author A, Producer P, Category C
                             where  B.AuthorID = A.AuthorID and B.ProducerID = P.ProducerID and B.CategoryID = C.CategoryID
                             group by BookID, BookName, CategoryName, Img, AuthorName, PriceUnit,  Sale,
                                       ProducerName, Quantity, BookStatus";
                SqlCommand cmd = new SqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            BookID = Convert.ToInt32(reader["BookID"]),
                            BookName = reader["BookName"].ToString(),
                            CategoryName = reader["CategoryName"].ToString(),
                            Img = reader["Img"].ToString(),
                            AuthorName = reader["AuthorName"].ToString(),
                            ProducerName = reader["ProducerName"].ToString(),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            PriceUnit = Convert.ToDouble(reader["PriceUnit"]).ToString("0,0 đ"),
                            Sale = Convert.ToDouble(reader["Sale"]).ToString("0,0 %"),
                            Total = Convert.ToDouble(reader["Total"]).ToString("0,0 đ"),
                            BookStatus = Convert.ToInt32(reader["BookStatus"]),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        // tim kiem sach hompage
        public List<object> search_SachHomePage(string searchString)
        {
            List<object> list = new List<object>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = @"select BookID, BookName,CategoryName,ProducerName, Img, AuthorName, Quantity, BookStatus,
                                      Sale, PriceUnit, sum(PriceUnit*(1-Sale)) Total  
                             from  Book B, Author A , Producer P, Category C  
                             where  B.AuthorID = A.AuthorID and P.ProducerID = B.ProducerID 
                                     and C.CategoryID = B.CategoryID and 
                                     (BookName like  '%' + @input + '%' 
                                     or BookID like   '%' + @input + '%' 
                                     or AuthorName like  '%' +  @input + '%' 
                                     or CategoryName like   '%' + @input + '%' 
                                     or ProducerName like   '%' + @input + '%' )
                             group by B.BookID, BookName, CategoryName, Img, AuthorName, PriceUnit,  Sale,
                                       ProducerName, Quantity, BookStatus";

                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("input", searchString);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            BookID = Convert.ToInt32(reader["BookID"]),
                            BookName = reader["BookName"].ToString(),
                            CategoryName = reader["CategoryName"].ToString(),
                            Img = reader["Img"].ToString(),
                            AuthorName = reader["AuthorName"].ToString(),
                            ProducerName = reader["ProducerName"].ToString(),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            PriceUnit = Convert.ToDouble(reader["PriceUnit"]).ToString("0,0 đ"),
                            Sale = Convert.ToDouble(reader["Sale"]).ToString("0,0 %"),
                            Total = Convert.ToDouble(reader["Total"]).ToString("0,0 đ"),
                            BookStatus = Convert.ToInt32(reader["BookStatus"]),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        //============================================================
        //=========================   NEWS   =========================
        //============================================================


        //
        public List<newsModel> sqlListNews()
        {
            List<newsModel> list = new List<newsModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT * FROM news ";
                SqlCommand cmd = new SqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new newsModel
                        {
                            NewsID = Convert.ToInt32(reader["NewsID"]),
                            NewsName = reader["NewsName"].ToString(),
                            NewsDay = reader["NewsDay"].ToString(),
                            NewsMonthYear = reader["NewsMonthYear"].ToString(),
                            Img = reader["Img"].ToString(),
                            short_description = reader["short_description"].ToString(),
                            Introduction = reader["Introduction"].ToString(),
                            Description = reader["Description"].ToString(),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        public newsModel detailsNews(int id)
        {
            newsModel p = new newsModel();
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    var str = "SELECT * FROM news  WHERE NewsID = @ID ";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("ID", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        //p.NewsID = Convert.ToInt32(reader["NewsID"]);
                        //p.NewsName = reader["NewsName"].ToString();
                        //p.NewsDay = reader["NewsDay"].ToString();
                        //p.NewsMonthYear = reader["NewsMonthYear"].ToString();
                        //p.Img = reader["Img"].ToString();
                        //p.short_description = reader["short_description"].ToString();
                        //p.Introduction = reader["Introduction"].ToString();
                        p.Description = reader["Description"].ToString();
                    }
                }
                catch(Exception e)
                {

                }
                conn.Close();
            }
            return (p);
        }

    }
}
