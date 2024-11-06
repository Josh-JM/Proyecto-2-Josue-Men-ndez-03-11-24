using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Proyecto__2_Josue_Menéndez_03_11_24
{
    public partial class Form1 : Form
    {
        List<User> LibrarianList = new List<User>();
        List<User> LectorList = new List<User>();
        public LinkedList<Book> BookList = new LinkedList<Book>();
        public Stack<Loan> LoanList = new Stack<Loan>();
        public Queue<LectorWaiting> LectorsWaiting = new Queue<LectorWaiting>();
        
        public Form1()
        {
            InitializeComponent();
            LibrarianList.Add(new User("Josh", "Perro"));
            LectorList.Add(new User("Andre", "Gato"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            PrincipalPanel.Visible = false;
            ContentPanel.Visible = true;

            ContentPanel.Controls.Clear();
            LectorLogin lectorLogin = new LectorLogin();
            lectorLogin.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(lectorLogin);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            PrincipalPanel.Visible = false;
            ContentPanel.Visible = true;

            ContentPanel.Controls.Clear();
            LibrarianLogin libriarianLogin = new LibrarianLogin();
            libriarianLogin.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(libriarianLogin);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        public void ShowPrincipalMenu()
        {
            ContentPanel.Visible = false;
            PrincipalPanel.Visible = true;

        }

        public bool FindUsersLibrarians (string username)
        {
            User FindUserInList = LibrarianList.Find(z => z.Username == username);
            if (FindUserInList == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool FindPasswordsLibrarians (string password)
        {
            User FindPasswordInList = LibrarianList.Find(z => z.Password == password);
            if (FindPasswordInList == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool FindUsersLectors(string username)
        {
            User FindUserInList = LectorList.Find(z => z.Username == username);
            if (FindUserInList == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool FindPasswordsLectors(string password)
        {
            User FindPasswordInList = LectorList.Find(z => z.Password == password);
            if (FindPasswordInList == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public void ShowLibrarianMenu()
        {
            PrincipalPanel.Visible = false;
            ContentPanel.Visible = true;

            ContentPanel.Controls.Clear();
            LibrarianMenu librarianMenu = new LibrarianMenu();
            librarianMenu.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(librarianMenu);

        }

        public void ShowLectorMenu ()
        {
            PrincipalPanel.Visible = false;
            ContentPanel.Visible = true;

            ContentPanel.Controls.Clear();
            LectorMenu lectorMenu = new LectorMenu();
            lectorMenu.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(lectorMenu);
        }

        public void ShowUsersManagementMenu ()
        {
            PrincipalPanel.Visible = false;
            ContentPanel.Visible = true;

            ContentPanel.Controls.Clear();
            UsersManagementMenu usersManagementMenu = new UsersManagementMenu();
            usersManagementMenu.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(usersManagementMenu);
        }

        public void ShowBooksManagementMenu()
        {
            PrincipalPanel.Visible = false;
            ContentPanel.Visible = true;

            ContentPanel.Controls.Clear();
            BooksManagementMenu booksManagementMenu = new BooksManagementMenu();
            booksManagementMenu.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(booksManagementMenu);
        }

        public void ShowReportsGeneration()
        {
            PrincipalPanel.Visible = false;
            ContentPanel.Visible = true;

            ContentPanel.Controls.Clear();
            ReportsGeneration reportsGeneration = new ReportsGeneration();
            reportsGeneration.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(reportsGeneration);
        }

        public void AddUser (string user, string password, string role)
        {
            if (role == "Bibliotecario")
            {
                LibrarianList.Add(new User(user, password));
            }
            else if (role == "Lector")
            {
                LectorList.Add(new User(user, password));
            }
        }

        public void EditUser(string user, string edit, string aspect)
        {
            if (aspect == "Usuario")
            {
                User UserEditSearchLibrarian = LibrarianList.Find(z => z.Username == user);
                if (UserEditSearchLibrarian != null)
                {
                    UserEditSearchLibrarian.Username = edit;
                }
                else if (UserEditSearchLibrarian == null)
                {
                    User UserEditSearchLector = LectorList.Find(z => z.Username == user);
                    UserEditSearchLector.Username = edit;
                }
            }
            else if (aspect == "Contraseña")
            {
                User UserEditSearchLibrarian = LibrarianList.Find(z => z.Username == user);
                if (UserEditSearchLibrarian != null)
                {
                    UserEditSearchLibrarian.Password = edit;
                }
                else if (UserEditSearchLibrarian == null)
                {
                    User UserEditSearchLector = LectorList.Find(z => z.Username == user);
                    UserEditSearchLector.Password = edit;
                }
            }
            else if (aspect == "Rol" && edit == "Lector")
            {
                User UserEditSearchLibrarian = LibrarianList.Find(z => z.Username == user);
                LectorList.Add(new User(UserEditSearchLibrarian.Username, UserEditSearchLibrarian.Password));
                LibrarianList.Remove(UserEditSearchLibrarian);
            }
            else if (aspect == "Rol" && edit == "Bibliotecario")
            {
                User UserEditSearchLector = LectorList.Find(z => z.Username == user);
                LibrarianList.Add(new User(UserEditSearchLector.Username, UserEditSearchLector.Password));
                LectorList.Remove(UserEditSearchLector);

            }
        }

        public void DeleteUser (string user)
        {
            User LibrarianDeleteSearch = LibrarianList.Find(z => z.Username == user);
            if (LibrarianDeleteSearch != null)
            {
                LibrarianList.Remove(LibrarianDeleteSearch);
            }
            else
            {
                User LectorDeleteSearch = LectorList.Find(z => z.Username == user);
                LectorList.Remove(LectorDeleteSearch);
            }
        }

        public void AddBook(string title, string author, string ISBN, string genre, bool availability)
        {
            BookList.AddLast(new Book(title, author, ISBN, genre, availability));
        }

        public Book SequentialBookSearch (LinkedList<Book> BookList, string title)
        {
            foreach (Book book in BookList)
            {
                if (book.Title == title)
                {
                    return book;
                }
            }
            return null;
        }

        public Book BookRemove(LinkedList<Book> BookList, string ISBN)
        {
            foreach (Book book in BookList)
            {
                if (book.ISBN == ISBN)
                {
                    return book;
                }
            }
            return null;

        }

        public void ShowLectorLoan ()
        {
            PrincipalPanel.Visible = false;
            ContentPanel.Visible = true;

            ContentPanel.Controls.Clear();
            LectorLoan lectorLoan = new LectorLoan();
            lectorLoan.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(lectorLoan);

        }


        public void ShowLectorDevolution ()
        {
            PrincipalPanel.Visible = false;
            ContentPanel.Visible = true;

            ContentPanel.Controls.Clear();
            LectorDevolution lectorDevolution = new LectorDevolution();
            lectorDevolution.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(lectorDevolution);

        }

        public void LoanAdd (Book book, User user)
        {
            LoanList.Push(new Loan(DateTime.Now, book, user, null));
        }

        public void UsersQueue (User user, string title)
        {
            LectorsWaiting.Enqueue(new LectorWaiting(user, title));
        }

        public LectorWaiting QueueSearch(string title)
        {
            foreach (LectorWaiting lectorWaiting in LectorsWaiting)
            {
                if (lectorWaiting.BookTitle == title)
                {
                    return lectorWaiting;
                }

            }

            return null;
        }

        public void Devolution(Book book, User user)
        {
            LoanList.Push(new Loan(null, book, user, DateTime.Now));
        }


        public User UserFinding (string user)
        {
            User UserLoanSearch = LectorList.Find(z => z.Username  == user);
            return UserLoanSearch;
        }
        public void DeleteQueueUserWaiting<LectorWaiting>(Queue<LectorWaiting> queue, LectorWaiting deleteLectorWaiting)
        {
            Queue<LectorWaiting> TemporalQueue = new Queue<LectorWaiting>();

            while (queue.Count > 0)
            {
                LectorWaiting ActualElement = queue.Dequeue();
                if (!EqualityComparer<LectorWaiting>.Default.Equals(ActualElement, deleteLectorWaiting))
                {
                    TemporalQueue.Enqueue(ActualElement);
                }
            }

            while (TemporalQueue.Count > 0)
            {
                queue.Enqueue(TemporalQueue.Dequeue());
            }
        }
         public void ShowReport(string textbox)
        {
            foreach (Loan loan in LoanList)
            {
                if (loan.DevolutionDate == null)
                {
                    textbox = ($"Fecha de Préstamo: {loan.LoanDate} " +  $"\nUsuario del Préstamo: {loan.Lector.Username}" + $"\nLibro Prestado: {loan.Book.Title}");
                }
            }
        }
    }
}
