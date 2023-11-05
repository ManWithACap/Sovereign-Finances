using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SovereignFinances
{
    internal static class Toolbox
    {
        private static List<Account> accountsList = new List<Account>();
        
        public static void LoadAccounts()
        {
            string[] acctLines = File.ReadAllLines(@"data/accounts.txt");
            List<Account> accounts = new List<Account>();
            for (int i = 0; i < acctLines.Length; i += 5)
            {
                Account acct = new Account()
                {
                    PlayerName = acctLines[i],
                    CharacterName = acctLines[i + 1],
                    AcctNum = acctLines[i + 2],
                    Balance = Int32.Parse(acctLines[i + 3]),
                    StarLevel = Int32.Parse(acctLines[i + 4])
                };
                accounts.Add(acct);
            }

            accountsList = accounts;
        }

        public static void LoadTransactions()
        {
            foreach (string filePath in Directory.GetFiles(@"data/transactions/"))
            {
                string filename = filePath.Replace("data/transactions/", string.Empty);
                string[] lines = File.ReadAllLines(filePath);

                foreach (Account account in Toolbox.Accounts)
                {
                    if (account.AcctNum == filename.Replace(".txt", string.Empty))
                    {
                        List<Transaction> transactions = new List<Transaction>();
                        for (int i = 0; i < lines.Length; i += 5)
                        {
                            Transaction transaction = new Transaction()
                            {
                                Name = lines[i],
                                Description = lines[i + 1],
                                Type = lines[i + 2],
                                Value = Int32.Parse(lines[i + 3]),
                                Time = DateTime.Parse(lines[i + 4])
                            };
                            transactions.Add(transaction);
                        }
                        account.Transactions = transactions;

                        foreach (Transaction transaction in account.Transactions)
                        {
                            Debug.WriteLine("\n\n" + filename + ": \n" +
                                transaction.Name + "\n" +
                                transaction.Description + "\n" +
                                transaction.Type + "\n" +
                                transaction.Value + "\n" +
                                transaction.Time + "\n");
                        }
                    }
                }
            }

            bool filesWereCreated = false;
            foreach (Account account in Toolbox.Accounts)
            {
                if (File.Exists($"data/transactions/{account.AcctNum}.txt"))
                {
                    Debug.WriteLine($"!! FILE FOUND FOR ID# {account.AcctNum} !!");
                }
                else
                {
                    Debug.WriteLine($"!! FILE NOT FOUND FOR ID# {account.AcctNum} !!\nCREATING FILE...");
                    File.Create($"data/transactions/{account.AcctNum}.txt").Close();
                    filesWereCreated = true;
                }
            }

            if (filesWereCreated)
            {
                LoadTransactions();
            }
        }

        public static List<Account> Accounts
        {
            get { return accountsList; }
        }
    }
}
