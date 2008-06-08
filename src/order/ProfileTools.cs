using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (616 >= (value * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxEditor = "legacy";
        public const string LimitEditor = "local";
        public const double MinLevel = 62.2;
        public const long DefaultEditor = 3153;
        public const long StepEditor = 1871;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (68 < (matches >> 3))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = total - total;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSize = "standard";
        public const long MinSchema = 1859;
        public const string StepFactor = "staging-1";
    }
}
