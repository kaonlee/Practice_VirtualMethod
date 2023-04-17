using Practice_VirtualMethod;

namespace TestProject1
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test_Engineer()
		{
			var testMember = new Engineer
			{
				Name = "¤j³¥´¼",
				BadegeID = "E001",
				RegularPay = 70000,
				OvertimePay = 5500
			};
			Employee testEngineer = testMember;
			int result = testEngineer.CalcTotalPay( );
			Assert.AreEqual(75500,result);
		}

		[Test]
		public void Test_Sales()
		{
			var testMember = new Sales
			{
				Name = "¤j³¥´¼",
				BadegeID = "E001",
				RegularPay = 70000,
				BonusPay = 5500
			};
			Employee testSales = testMember;
			int result = testSales.CalcTotalPay( );
			Assert.AreEqual( 75500, result );
		}

		[Test]
		public void Test_Management()
		{
			var testMember = new Management
			{
				Name = "¤j³¥´¼",
				BadegeID = "E001",
				RegularPay = 70000,
				Subordinates =new List<Employee> { }
			};

			var subordinate1 = new Employee { BadegeID = "S01", Name = "Sub", RegularPay = 35000 };
			testMember.Subordinates.Add( subordinate1 );

			Employee testManager = testMember;
			int result = testManager.CalcTotalPay( );
			Assert.AreEqual( 170000, result );
		}
	}
}