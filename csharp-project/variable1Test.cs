using Answer;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.IO;

namespace TechIo
{
    [TestClass]
    public class UniverseTest
    {
	
	[TestMethod]
	public void VerifyVariable() 
	{
		// On success
			if((ExistsInFile(@"/project/target/Exercises/variable1.cs","int compteur = 255;)||(ExistsInFile(@"/project/target/Exercises/variable1.cs","int compteur=255;)) 
			{
				Success(true);
				PrintMessage("BRAVO","Tu es trop fort !");
				
			}
			else 
			{
				Success(false);
				PrintMessage("NON ", "Revoir le cours déclaraton de variable. essaye encore!");
				
			}	
	}

	

	/****
		TOOLS
	*****/
	// Display a custom message in a custom channel
	private static void PrintMessage(String channel, String message)
	{		
		Console.WriteLine ($"TECHIO> message --channel \"{channel}\" \"{message}\"");
	}
	// You can manually handle the success/failure of a testcase using this function
	private static void Success(Boolean success)
	{
		Console.WriteLine($"TECHIO> success {success}");
	}
	// Check the user code looking for a keyword
	private static Boolean ExistsInFile(String path, String keyword) 
	{
		return File.ReadAllText(path).Contains(keyword);
	}
	
    }
}
