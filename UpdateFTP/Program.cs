/*
 * Created by SharpDevelop.
 * User: LOL
 * Date: 24/01/2018
 * Time: 23.50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace UpdateFTP
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
	    /// <summary>
	    /// Program entry point.
	    /// </summary>
	    [STAThread]
	    private static void Main(string[] args)
	    {
	        Application.EnableVisualStyles();
	        Application.SetCompatibleTextRenderingDefault(false);
	        Application.Run(new FormTDS());
	    }

	}
}
