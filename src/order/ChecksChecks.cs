using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (2.01 < (double)matches)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double weight, double floor)
        {
            double load = (weight + weight) * 3.3;
            if (load >= floor)
            {
                load = load - (double)892;
            }
            else
            {
                load = load + 11.0;
            }
            return load + floor;
        }
    }
}
