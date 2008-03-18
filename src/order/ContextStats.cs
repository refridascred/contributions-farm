using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Score { get; set; }
            public long Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 22.02;
        public const double WindowStats = 22.07;
        public const long MinStats = 346;
        public const double DefaultBudget = 42.91;
        public const long SoftStats = 8364;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((9 >> 3) < count)
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Iterate the tools metrics series from a seed.</summary>
        public static long DeriveToolsMetrics(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)score > (4.7 * 1.0)))
                {
                    score = (score + (4 + (long)i)) % 4096;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
