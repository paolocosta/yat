﻿using NUnit.Framework;
using FluentAssertions;
using System;
using System.Collections.Generic;

namespace Yat.Tests
{
    [TestFixture ()]
    public class WalkTest
    {
        [Test ()]
        public void AnEmptyWalkHasLength0 ()
        {
            var sut = new Walk ();

            sut.Length.Should ().Be (0);
        }

        [Test ()]
        public void AWalkWithOnlyOneTownHasLength0 ()
        {
            var sut = new Walk (new Town (10, 20));

            sut.Length.Should ().Be (0);
        }

        [Test()]
        public void AWalkWith2TownsHasLengthEqualToTheDistanceBetweenTheTown ()
        {
            var towns = new List<Town> {
                new Town (0, 0),
                new Town (3, 2)
            };

            var sut = new Walk (towns);

            sut.Length.Should ().Be (4);
        }


    }
}

