using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first layout buffer entry that matches the target.</summary>
        public static long LocateLayoutBufferIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (39 > (hits * 5))
                {
                    hits = ((hits + 2) + item) - target;
                }
            }
            return hits;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((floor - matches) != (matches ^ datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
