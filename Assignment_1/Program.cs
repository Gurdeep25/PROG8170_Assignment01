using System;

namespace Assignment_1
{
	class Program
	{
//input for menu
		public int menuInput;
		static void Main(string[] args)
		{

//object of class
			Rectangle myRectangle = new Rectangle();  
			
//input for rectangle, length and width
			bool correctInput = false;
			while (true)
			{
				try
				{
					do
					{
						Console.WriteLine("Enter the Length and Width of the rectangle:");
						Console.WriteLine("********************************************");

						Console.WriteLine("Enter the Length of rectangle:");
						int lengthOfRectangle = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Enter the Width of rectangle:");
						int widthOfRectangle = Convert.ToInt32(Console.ReadLine());
						

						if (lengthOfRectangle > 0 && widthOfRectangle > 0)
						{
							correctInput = true;
						}
						else
						{
							Console.WriteLine("Please input correct values, length and width should be greater than 0");
							correctInput = false;
						}
					}
					while (correctInput == false);
					break;
				}
				catch (Exception e)
				{
					Console.WriteLine("Invalid input, please enter the number as input");
					continue;
				}
			}

//Menu
			bool correctInputMenu = false;
			while (true)
			{
				try
				{

					do
					{
						Console.WriteLine("Menu");
						Console.WriteLine("*****");
						Console.WriteLine("Please select from below Menu");
						Console.WriteLine("1: Get Length of the Rectangle");
						Console.WriteLine("2: Set Length of the Rectangle");
						Console.WriteLine("3: Get Width of the Rectangle");
						Console.WriteLine("4: Set Width of the Rectangle");
						Console.WriteLine("5: Get Perimeter of the Rectangle");
						Console.WriteLine("6: Get Area of the Rectangle");
						Console.WriteLine("7: Exit the Menu");

						int menuInput = Convert.ToInt32(Console.ReadLine());

						if(menuInput == 1)
						{
							Console.WriteLine(myRectangle.GetLength());
						}
						else if(menuInput == 2)
						{
							bool correctInputLength = false;
							while (true)
							{
								try
								{
									do
									{
										Console.WriteLine("Enter the Length of rectangle:");
										int lengthOfRectangle = Convert.ToInt32(Console.ReadLine());
										Console.WriteLine(myRectangle.SetLength(lengthOfRectangle));
										correctInputLength = true;
									}
									while (correctInputLength == false);
									break;
								}
								catch(Exception e)
								{
									Console.WriteLine("Invalid input, please enter the number as input");
									continue;
								}
							}
						}
						else if (menuInput == 3)
						{
							Console.WriteLine(myRectangle.GetWidth());
						}
						else if (menuInput == 4)
						{
							bool correctInputWidth = false;
							while (true)
							{
								try
								{
									do
									{
										Console.WriteLine("Enter the Width of rectangle:");
										int widthOfRectangle = Convert.ToInt32(Console.ReadLine());
										Console.WriteLine(myRectangle.SetWidth(widthOfRectangle));
										correctInputWidth = true;
									}
									while (correctInputWidth == false);
									break;
								}
								catch (Exception e)
								{
									Console.WriteLine("Invalid input, please enter the number as input");
									continue;
								}
							}
						}
						else if (menuInput == 5)
						{
							Console.WriteLine(myRectangle.GetPerimeter());
						}
						else if (menuInput == 6)
						{
							Console.WriteLine(myRectangle.GetArea());
						}
						else if (menuInput == 7)
						{
							Environment.Exit(0);
						}
						else
						{
							Console.WriteLine("Please choose the option from menu");
						}

					}
					while (correctInputMenu == false);
					break;
				}
				catch (Exception e)
				{
					Console.WriteLine("Invalid input, Please select the correct menu option from available list of Menu");
					continue;
				}
					
		
			}


		}


	}
}
