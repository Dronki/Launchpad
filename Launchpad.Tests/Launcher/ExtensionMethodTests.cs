﻿//
//  ExtensionMethodTests.cs
//
//  Author:
//       Jarl Gullberg <jarl.gullberg@gmail.com>
//
//  Copyright (c) 2017 Jarl Gullberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using Launchpad.Launcher.Utility;
using NUnit.Framework;

namespace Launchpad.Tests.Launcher
{
	[TestFixture]
	public class ExtensionMethodTests
	{
		private const string Expected = "data";
		private const string StringThatContainsNulls = "data\0\0";
		private const string StringThatContainsCarriageReturns = "data\r\r";
		private const string StringThatContainsLinefeeds = "data\n\n";
		private const string StringThatContainsEverything = "data\0\r\n";

		[Test]
		public void TestRemoveNulls()
		{
			Assert.AreEqual(Expected, StringThatContainsNulls.RemoveLineSeparatorsAndNulls());
		}

		[Test]
		public void TestRemoveCarriageReturns()
		{
			Assert.AreEqual(Expected, StringThatContainsCarriageReturns.RemoveLineSeparatorsAndNulls());
		}

		[Test]
		public void TestRemoveLinefeeds()
		{
			Assert.AreEqual(Expected, StringThatContainsLinefeeds.RemoveLineSeparatorsAndNulls());
		}

		[Test]
		public void TestRemoveNullsCarriageReturnsLinefeeds()
		{
			Assert.AreEqual(Expected, StringThatContainsEverything.RemoveLineSeparatorsAndNulls());
		}
	}
}