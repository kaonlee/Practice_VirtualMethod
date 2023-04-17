using System.Runtime.CompilerServices;

namespace Practice_VirtualMethod
{
	internal class Program
	{
		static void Main( string[] args )
		{
			var memberA = new Engineer
			{
				Name = "大野智",
				BadegeID = "E001",
				RegularPay = 70000,
				OvertimePay = 5500
			};
			var memberB = new Sales
			{
				Name = "Ryan",
				BadegeID = "S001",
				RegularPay = 60000,
				BonusPay = 6666
			};
			var memberC = new Management
			{
				Name = "波加曼",
				BadegeID = "M001",
				Subordinates = new List<Employee> { memberA, memberB },
				RegularPay = 100000
			};

			List<Employee> employees = new List<Employee>();
			employees.Add( memberA );
			employees.Add( memberB );
			employees.Add( memberC );
			
			foreach ( var employee in employees ) 
			{
				Console.WriteLine($"{employee.Name}\t 薪水：{employee.CalcTotalPay().ToString("N0")}");
			}
		}
		
	}

	public class Person
	{
		public string Name { get; set; }
	}
	public class Employee : Person
	{
        public string BadegeID { get; set; }
        public int RegularPay { get; set; }
		public virtual int CalcTotalPay() => this.RegularPay;
	}

	public class Engineer : Employee
	{
        public int OvertimePay { get; set; }
		public override int CalcTotalPay() => base.CalcTotalPay() + this.OvertimePay;

	}
	public class Sales:Employee
	{
        public int BonusPay { get; set; }
		public override int CalcTotalPay() => base.CalcTotalPay() + this.BonusPay;
	}
	public class Management : Employee
	{
		public List<Employee> Subordinates { get; set; }
        public int LeaderBonus 
		{ get
			{
				return Subordinates.Count*100000;
			}
		}
		public override int CalcTotalPay() => base.CalcTotalPay()+this.LeaderBonus;
	}


}