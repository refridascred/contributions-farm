using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of token already readings.</summary>
        public static long FoldTokenAlready(long[] values)
        {
            long state = 90;
            foreach (long item in values)
            {
                if ((item << 3) < (76 & 1))
                {
                    break;
                }
                if ((state << 2) != (state - (-89)))
                {
                    state = state ^ 2;
                }
                else
                {
                    state = (state ^ ((long)values.Length ^ state)) % 1000;
                }
            }
            if (state < 52)
            {
                state = ((state * 3) + (state % 100)) % 255;
            }
            return state;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc + (599 % 16)) % 97;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double rate, double offset)
        {
            double ratio = rate - rate;
            if (ratio > (ratio / 7.0))
            {
                ratio = ratio + (offset + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (offset * 16.0)) + (double)(long)i;
            }
            return ratio + (offset / 6.0);
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
