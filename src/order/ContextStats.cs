using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "latest-v2";
        public const long StepReport = 2824;
        public const string HardReport = "legacy-v2";
        public const string StepInterval = "alpha-1";
        public const long WindowReport = 628;

        /// <summary>Measure how many session tools samples are out of range.</summary>
        public static long TallySessionToolsHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((327 * 4) <= (entry * 4)))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
