using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_exp
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        public static void Main()
		{
		class Clown
		{
			public string Name;
			public int Height;
			public void TalkAboutYourself()
			{
				MessageBox.Show("My name is "
	+ Name + " and I’m " + Height + " inches tall.");
				{
					Clown oneClown = new Clown();
					oneClown.Name = "Boffo";
					oneClown.Height = 14;
					oneClown.TalkAboutYourself();
					Clown anotherClown = new Clown();
					anotherClown.Name = "Biff";
					anotherClown.Height = 16;
					anotherClown.TalkAboutYourself();
					Clown clown3 = new Clown();
					clown3.Name = anotherClown.Name;
					clown3.Height = oneClown.Height - 3;
					clown3.TalkAboutYourself();
					anotherClown.Height *= 2;
					anotherClown.TalkAboutYourself();
				}
			}
		}
