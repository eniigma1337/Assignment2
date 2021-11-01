using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
	public class J1Controller : ApiController
	{
		/// <summary>
		/// Inputs the choice of burgers, drinks, sides, desserts and calculates the calories
		/// </summary>
		/// <param name="burger">burger choice(1 - 4)</param>
		/// <param name="drink">drinks choice(1 - 4)</param>
		/// <param name="side">sides choice(1 - 4)</param>
		/// <param name="dessert">desserts choice (1 - 4)</param>
		///<example>
		///GET: api/J1/Menu/2/4/3/4
		///</example>
		/// <returns>Your total calorie count is 501</returns>
		//GET: api/j1/Menu
		[HttpGet]
		[Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]

		public string Menu(int burger, int drink, int side, int dessert)
		{
			int calorie = 0;

			if (burger == 1)
			{
				calorie += 461;
			}
			else if (burger == 2)
			{
				calorie += 431;
			}
			else if (burger == 3)
			{
				calorie += 420;
			}
			else if (burger == 4)
			{
				calorie = 0;
			}

			if (drink == 1)
			{
				calorie += 130;
			}
			else if (drink == 2)
			{
				calorie += 160;
			}
			else if (drink == 3)
			{
				calorie += 118;
			}
			else if (drink == 4)
			{
				calorie += 0;
			}

			if (side == 1)
			{
				calorie += 100;
			}
			else if (side == 2)
			{
				calorie += 57;
			}
			else if (side == 3)
			{
				calorie += 70;
			}
			else if (side == 4)
			{
				calorie += 0;
			}


			if (dessert == 1)
			{
				calorie += 167;
			}
			else if (dessert == 2)
			{
				calorie += 266;
			}
			else if (dessert == 3)
			{
				calorie += 75;
			}
			else if (dessert == 4)
			{
				calorie += 0;
			}

			string message = "Your total calories count is: " + calorie;
			return message;

		}
	}
}


