/*
 * Created by SharpDevelop.
 * User: user
 * Date: 11/24/2020
 * Time: 9:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SharpDevelopWebApi.Models
{
	/// <summary>
	/// Description of Students.
	/// </summary>
	public class Students : Person1
	{
		public string SchoolLastAttended { get; set; }
		public int CourseId { get; set;}
	}
}
