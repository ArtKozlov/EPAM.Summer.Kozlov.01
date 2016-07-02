using System;
using FootballTeam;
using System.Reflection;
[assembly: AssemblyKeyFile("Keypair.snk")]
class Program
{
	static void Main()
	{
		RealMadrid team1 = new RealMadrid();
		team1.TeamInfo();

		Barcelona team2 = new Barcelona();
		team2.TeamInfo();

		Belshina team3 = new Belshina();
		team3.TeamInfo();

		Console.ReadLine();
	}
}
