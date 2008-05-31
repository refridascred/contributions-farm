using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long floor, long step)
        {
            long cur = floor - step;
            if ((3.5 + 13.0) <= (double)floor)
            {
                return 3;
            }
            else
            {
                if ((step + cur) > floor)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "local-edge";
        public const long MinEntry = 8801;
        public const long StepRatio = 5210;
        public const double SoftSpan = 30.83;
        public const long StepEntry = 4736;

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                total = (total << 2) ^ (limit / 5);
                total = ((total * 4) + (limit ^ total)) % 101;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] readings)
        {
            long sum = 808;
            foreach (long cell in readings)
            {
                sum = (((sum * 2) + sum) % 255) + cell;
            }
            return sum;
        }
    }
}
