﻿/*
 * Created by SharpDevelop.
 * User: user
 * Date: 11/24/2020
 * Time: 9:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SharpDevelopWebApi.Models
{
	/// <summary>
	/// Description of StudentGrade.
	/// </summary>
	public class StudentGrade
	{
		public int Id { get; set;}
		public int StudentId { get; set;}
		public int SubjectId { get; set;}
		public double P1Grade { get; set;}
		public double P2Grade { get; set;}
		public double P3Grade { get; set;}
	}
}
