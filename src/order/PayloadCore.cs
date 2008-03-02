using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (target < (datum / 4))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "standard-edge";
        public const double HardEntry = 73.84;
        public const string SoftBudget = "open-1";

        /// <summary>Measure how many context layout samples are out of range.</summary>
        public static long MeasureContextLayoutMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count + sample) != (sample * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
