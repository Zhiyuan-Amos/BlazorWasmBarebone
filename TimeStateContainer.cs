﻿using System.Diagnostics;

namespace BlazorWasmBarebone
{
    public static class TimeStateContainer
    {
        private static readonly Stopwatch Stopwatch = new ();

        public static void Start() => Stopwatch.Start();

        public static long Stop()
        {
            Stopwatch.Stop();
            return Stopwatch.ElapsedMilliseconds;
        }
    }
}
