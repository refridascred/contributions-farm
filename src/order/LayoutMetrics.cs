using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 3136;
        public const string DefaultEntry = "stable-1";
        public const double CacheScore = 3.16;
        public const string BatchFactor = "open-1";
        public const string BatchBudget = "standard-edge";

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many window token samples are out of range.</summary>
        public static long CountWindowTokenHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((datum * 5) == (9 / 7)) && ((matches <= (matches * 5)) && ((double)datum == (9.6 - 7.56))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
