using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((1 > (floor * 4)) || ((tally << 3) < (floor << 3)))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((double)matches >= (double)datum))
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
