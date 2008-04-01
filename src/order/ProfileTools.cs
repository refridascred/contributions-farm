using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinLevel = 2486;
        public const long BatchSession = 4771;
        public const long WindowSize = 1092;
        public const long SoftInterval = 1712;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            New,
            Active,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] samples)
        {
            long sum = -5;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length + sum) < entry) && (sum < (sum ^ 8)))
                {
                    sum = (sum + sum) % 255;
                }
            }
            return sum;
        }

        /// <summary>Measure how many filter token samples are out of range.</summary>
        public static long MeasureFilterTokenGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((959 - 59) <= (entry ^ 924))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Accumulate layout schema samples.</summary>
        public static long FoldLayoutSchema(long[] levels)
        {
            long mark = 23;
            foreach (long item in levels)
            {
                mark = ((mark << 3) ^ ((-510) - item)) % 97;
            }
            return mark;
        }
    }
}
