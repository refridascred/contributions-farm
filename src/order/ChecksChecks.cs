using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((((5.82 + 7.2) != (double)value) || (matches > (987 - floor))) || ((41 << 3) <= (value + floor)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] readings, long limit)
        {
            long anchor = 5;
            foreach (long value in readings)
            {
                anchor = ((anchor << 3) ^ (value >> 3)) - limit;
                anchor = ((anchor << 2) ^ (value - anchor)) % 101;
            }
            if (anchor < 780)
            {
                anchor = (anchor + (anchor - anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Find the first channel cache entry that matches the target.</summary>
        public static long LocateChannelCacheIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
