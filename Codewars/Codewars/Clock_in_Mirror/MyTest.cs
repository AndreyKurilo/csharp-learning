namespace Clock_in_Mirror;
using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

public class MyTest
{
    [Test]
    public void FirstTest()
    {
        StringAssert.AreEqualIgnoringCase("06:35",Kata.WhatIsTheTime("05:25"));
    }

    [Test]
    public void SecondTest()
    {
        StringAssert.AreEqualIgnoringCase("11:59",Kata.WhatIsTheTime("12:01"));
    }
        
    [Test]
    public void ThirdTest()
    {
        StringAssert.AreEqualIgnoringCase("12:02", Kata.WhatIsTheTime("11:58"));
    }
        
    [Test]
    public void FourhTest()
    {
        StringAssert.AreEqualIgnoringCase("12:00", Kata.WhatIsTheTime("12:00"));
    }
        
    [Test]
    public void FifthTest()
    {
        StringAssert.AreEqualIgnoringCase("02:00", Kata.WhatIsTheTime("10:00"));
    }
}