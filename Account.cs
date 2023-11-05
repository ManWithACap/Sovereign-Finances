using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SovereignFinances
{
    internal class Account
    {
        private string playerName;
        private string characterName;
        private string acctNum;
        private int balance;
        private int starLevel;
        private List<Transaction> transactions;

        public Account()
        {
            
        }

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public string CharacterName
        {
            get { return characterName; }
            set { characterName = value; }
        }

        public string AcctNum
        {
            get { return acctNum; }
            set { acctNum = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public int StarLevel
        {
            get { return starLevel; }
            set { starLevel = value; }
        }

        public List<Transaction> Transactions
        {
            get { return transactions; }
            set { transactions = value; }
        }
    }
}
