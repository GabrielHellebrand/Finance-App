  class App
    {
        private List<User> users;
        private User currentUser;

        public FinancialManagementApp()
        {
            users = new List<User>();
            currentUser = null;
        }

        public void Run()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Welcome to the Financial Management App!");

                if (currentUser == null)
                {
                    Console.WriteLine("1. Register");
                    Console.WriteLine("2. Login");
                    Console.WriteLine("3. Exit");
                    Console.Write("Please enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            RegisterUser();
                            break;
                        case "2":
                            Login();
                            break;
                        case "3":
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("1. Dashboard");
                    Console.WriteLine("2. Add Income");
                    Console.WriteLine("3. Add Expense");
                    Console.WriteLine("4. Track Savings");
                    Console.WriteLine("5. Manage Investments");
                    Console.WriteLine("6. Set Financial Goals");
                    Console.WriteLine("7. Logout");
                    Console.Write("Please enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            DisplayDashboard();
                            break;
                        case "2":
                            AddIncome();
                            break;
                        case "3":
                            AddExpense();
                            break;
                        case "4":
                            TrackSavings();
                            break;
                        case "5":
                            ManageInvestments();
                            break;
                        case "6":
                            SetFinancialGoals();
                            break;
                        case "7":
                            Logout();
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
        }

        private void RegisterUser()
        {
            Console.Write("Enter a username: ");
            string username = Console.ReadLine();

            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            // Check if the username is already taken
            if (users.Exists(u => u.Username == username))
            {
                Console.WriteLine("Username is already taken. Please choose a different username.");
                return;
            }

            // Create a new user and add it to the list
            User newUser = new User(username, password);
            users.Add(newUser);
            currentUser = newUser;

            Console.WriteLine("Registration successful. You are now logged in.");
        }

        private void Login()
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            // Check if the username and password match an existing user
            User user = users.Find(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                currentUser = user;
                Console.WriteLine("Login successful. Welcome, " + currentUser.Username + "!");
            }
            else
            {
                Console.WriteLine("Invalid username or password. Please try again.");
            }
        }

        private void Logout()
        {
            currentUser = null;
            Console.WriteLine("Logout successful. Thank you for using the Financial Management App!");
        }

        private void DisplayDashboard()
        {
            Console.WriteLine("Dashboard");
    
{
        // Financial data
        decimal income = 5000;
        decimal expenses = 3000;
        decimal savings = 2000;
        decimal[] investmentPortfolio = { 10000, 15000, 20000, 5000 };

        // Display financial overview
        Console.WriteLine("Financial Overview");
        Console.WriteLine("------------------");
        Console.WriteLine("Income: {0:C}", income);
        Console.WriteLine("Expenses: {0:C}", expenses);
        Console.WriteLine("Savings: {0:C}", savings);

        Console.WriteLine("Investment Portfolio:");
        for (int i = 0; i < investmentPortfolio.Length; i++)
        {
            Console.WriteLine("  Investment {0}: {1:C}", i + 1, investmentPortfolio[i]);
        }

        // Calculate net worth
        decimal netWorth = CalculateNetWorth(income, expenses, savings, investmentPortfolio);
        Console.WriteLine("Net Worth: {0:C}", netWorth);
    }

    static decimal CalculateNetWorth(decimal income, decimal expenses, decimal savings, decimal[] investmentPortfolio)
    {
        decimal totalInvestments = 0;
        foreach (decimal investment in investmentPortfolio)
        {
            totalInvestments += investment;
        }

        decimal netWorth = income - expenses + savings + totalInvestments;
        return netWorth;
    }
        }

        private void AddIncome()
        {
            Console.WriteLine("Add Income");

{
        List<IncomeSource> incomeSources = new List<IncomeSource>();

        while (true)
        {
            Console.WriteLine("1. Add Income Source");
            Console.WriteLine("2. Track Income Sources");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddIncomeSource(incomeSources);
                    break;
                case "2":
                    TrackIncomeSources(incomeSources);
                    break;
                case "3":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddIncomeSource(List<IncomeSource> incomeSources)
    {
        Console.Write("Enter the name of the income source: ");
        string name = Console.ReadLine();

        Console.Write("Enter the amount: ");
        string amountInput = Console.ReadLine();
        decimal amount;

        if (!decimal.TryParse(amountInput, out amount))
        {
            Console.WriteLine("Invalid amount. Please try again.");
            return;
        }

        IncomeSource incomeSource = new IncomeSource
        {
            Name = name,
            Amount = amount
        };

        incomeSources.Add(incomeSource);
        Console.WriteLine("Income source added successfully!");
    }

    static void TrackIncomeSources(List<IncomeSource> incomeSources)
    {
        if (incomeSources.Count == 0)
        {
            Console.WriteLine("No income sources to track.");
            return;
        }

        Console.WriteLine("Income Sources:");
        Console.WriteLine("---------------");

        foreach (IncomeSource incomeSource in incomeSources)
        {
            Console.WriteLine($"Name: {incomeSource.Name}");
            Console.WriteLine($"Amount: {incomeSource.Amount:C}");
            Console.WriteLine();
        }
    }
        }

        private void AddExpense()
        {
            Console.WriteLine("Add Expense");
    
{
            while (true)
            {
                Console.WriteLine("Expense Tracker");
                Console.WriteLine("---------------------");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. View Expenses");
                Console.WriteLine("3. Exit");
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddExpense();
                        break;
                    case "2":
                        ViewExpenses();
                        break;
                    case "3":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddExpense()
        {
            Console.WriteLine("Add Expense");
            Console.WriteLine("---------------------");

            Expense expense = new Expense();

            Console.Write("Category: ");
            expense.Category = Console.ReadLine();

            Console.Write("Description: ");
            expense.Description = Console.ReadLine();

            Console.Write("Amount: ");
            decimal amount;
            if (decimal.TryParse(Console.ReadLine(), out amount))
            {
                expense.Amount = amount;
            }
            else
            {
                Console.WriteLine("Invalid amount! Please enter a valid decimal value.");
                return;
            }

            Console.Write("Date (yyyy-MM-dd): ");
            DateTime date;
            if (DateTime.TryParse(Console.ReadLine(), out date))
            {
                expense.Date = date;
            }
            else
            {
                Console.WriteLine("Invalid date! Please enter a valid date in the specified format.");
                return;
            }

            expenses.Add(expense);

            Console.WriteLine("Expense added successfully!");
        }

        static void ViewExpenses()
        {
            Console.WriteLine("View Expenses");
            Console.WriteLine("---------------------");

            if (expenses.Count == 0)
            {
                Console.WriteLine("No expenses recorded yet.");
                return;
            }

            Console.WriteLine("Category\tDescription\tAmount\tDate");
            Console.WriteLine("--------------------------------------------------");

            foreach (var expense in expenses)
            {
                Console.WriteLine($"{expense.Category}\t\t{expense.Description}\t{expense.Amount}\t{expense.Date.ToString("yyyy-MM-dd")}");
            }
        }
    }


        private void TrackSavings()
        {
            Console.WriteLine("Track Savings");

             while (true)
{
            Console.WriteLine("1. Create Savings Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Set Savings Goal");
            Console.WriteLine("5. Track Progress");
            Console.WriteLine("6. Exit");
            Console.WriteLine();

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateSavingsAccount();
                    break;
                case 2:
                    Deposit();
                    break;
                case 3:
                    Withdraw();
                    break;
                case 4:
                    SetSavingsGoal();
                    break;
                case 5:
                    TrackProgress();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CreateSavingsAccount()
    {
        Console.Write("Enter account number: ");
        string accountNumber = Console.ReadLine();

        Console.Write("Enter initial balance: ");
        decimal initialBalance = decimal.Parse(Console.ReadLine());

        SavingsAccount account = new SavingsAccount(accountNumber, initialBalance);
        savingsAccounts.Add(account);

        Console.WriteLine("Savings account created successfully");
    }

    static void Deposit()
    {
        Console.Write("Enter account number: ");
        string accountNumber = Console.ReadLine();

        SavingsAccount account = GetSavingsAccount(accountNumber);
        if (account != null)
        {
            Console.Write("Enter amount to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            account.Deposit(amount);
            Console.WriteLine("Deposit successful");
        }
    }

    static void Withdraw()
    {
        Console.Write("Enter account number: ");
        string accountNumber = Console.ReadLine();

        SavingsAccount account = GetSavingsAccount(accountNumber);
        if (account != null)
        {
            Console.Write("Enter amount to withdraw: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            account.Withdraw(amount);
            Console.WriteLine("Withdrawal successful");
        }
    }

    static void SetSavingsGoal()
    {
        Console.Write("Enter account number: ");
        string accountNumber = Console.ReadLine();

        SavingsAccount account = GetSavingsAccount(accountNumber);
        if (account != null)
        {
            Console.Write("Enter savings goal: ");
            decimal savingsGoal = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Savings goal of {savingsGoal} set for account {accountNumber}");
            account.Balance = 0; // Reset balance when setting a new savings goal
        }
    }

    static void TrackProgress()
    {
        Console.Write("Enter account number: ");
        string accountNumber = Console.ReadLine();

        SavingsAccount account = GetSavingsAccount(accountNumber);
        if (account != null)
        {
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Current Balance: {account.Balance}");
        }
    }

    static SavingsAccount GetSavingsAccount(string accountNumber)
    {
        SavingsAccount account = savingsAccounts.Find(a => a.AccountNumber == accountNumber);
        if (account == null)
        {
            Console.WriteLine("Savings account not found");
        }
        return account;
    }


        private void ManageInvestments()
        {
            Console.WriteLine("Manage Investments");

{
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Add Investment");
            Console.WriteLine("2. View Investments");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddInvestment();
                    break;
                case "2":
                    ViewInvestments();
                    break;
                case "3":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddInvestment()
    {
        Console.Write("Enter the investment name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the investment amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        investments.Add(new Investment { Name = name, Amount = amount });

        Console.WriteLine("Investment added successfully!");
    }

    static void ViewInvestments()
    {
        if (investments.Count == 0)
        {
            Console.WriteLine("No investments found.");
        }
        else
        {
            Console.WriteLine("Investments:");
            Console.WriteLine("------------------------------");
            foreach (var investment in investments)
            {
                Console.WriteLine($"Name: {investment.Name}");
                Console.WriteLine($"Amount: {investment.Amount}");
                Console.WriteLine("------------------------------");
            }
        }
    }
}
        private void SetFinancialGoals()
        {
            Console.WriteLine("Set Financial Goals");

{
        while (true)
        {
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Track Goal");
            Console.WriteLine("3. Exit");
            Console.WriteLine();

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    AddGoal();
                    break;
                case "2":
                    TrackGoal();
                    break;
                case "3":
                    Console.WriteLine("Exiting the program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter target amount: ");
        decimal targetAmount = decimal.Parse(Console.ReadLine());

        goals.Add(new FinancialGoal
        {
            Name = name,
            TargetAmount = targetAmount,
            CurrentAmount = 0
        });

        Console.WriteLine("Goal added successfully!");
    }

    static void TrackGoal()
    {
        Console.WriteLine("Goals:");
        Console.WriteLine("------");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        Console.WriteLine();

        Console.Write("Enter goal number to track: ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        if (goalNumber >= 0 && goalNumber < goals.Count)
        {
            FinancialGoal goal = goals[goalNumber];

            Console.WriteLine();
            Console.WriteLine($"Goal: {goal.Name}");
            Console.WriteLine($"Target Amount: {goal.TargetAmount}");
            Console.WriteLine($"Current Amount: {goal.CurrentAmount}");

            Console.WriteLine();
            Console.WriteLine("1. Update current amount");
            Console.WriteLine("2. Back to main menu");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter updated current amount: ");
                    decimal currentAmount = decimal.Parse(Console.ReadLine());
                    goal.CurrentAmount = currentAmount;
                    Console.WriteLine("Current amount updated successfully!");
                    break;
                case "2":
                    break;
                default:
                    Console.WriteLine("Invalid choice. Returning to main menu.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid goal number. Returning to main menu.");
        }
    }
}
}