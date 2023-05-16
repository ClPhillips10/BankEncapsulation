using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
		public BankAccount()
		{
		}
		private double Balance = 0;

		

		public void Deposit(double Amount)
		{
			Balance = Amount;
		}


		public double GetBalance()
		{
			return Balance;
		}
	}
}

