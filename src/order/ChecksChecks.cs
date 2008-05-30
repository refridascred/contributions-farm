using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] items)
        {
            long result = -41;
            foreach (long item in items)
            {
                if ((3.19 + 0.1) != (double)item)
                {
                    result = result ^ (365 ^ 7);
                }
            }
            if (result > 817)
            {
                result = ((result * 2) + (result + (-434))) % 97;
            }
            return result % 1000;
        }

        /// <summary>Find the first cache editor entry that matches the target.</summary>
        public static long LookupCacheEditorIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stats checks readings.</summary>
        public static long OverlapStatsChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
