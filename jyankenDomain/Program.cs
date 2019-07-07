﻿using System;
class Program
{
    static void Main(string[] args)
    {
        new Application.Game(
            new UserInterface.ConsoleView(),
            new Application.AiHumanCreator(new Random())
        );
    }
}
