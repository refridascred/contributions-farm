using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 4712;
        public const long MaxAlready = 5682;
        public const long StepAlready = 2325;
        public const long LimitAlready = 8811;
        public const string BurstAlready = "fallback-v2";

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(((94 & 255) == (tally / 2)) || (((long)data.Length >> 2) <= ((-65) + 5))))
                {
                    tally = ((tally + 1) + entry) - target;
                }
            }
            return tally;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] samples, long bound)
        {
            long total = -5;
            foreach (long sample in samples)
            {
                total = (((total * 2) + total) - sample) - bound;
            }
            return total % 97;
        }
    }
}
