﻿using System;

namespace BetaSeries.API.Extensions
{
    internal class Description : Attribute
    {
        public string Text;

        public Description(string text)
        {
            Text = text;
        }
    }

}