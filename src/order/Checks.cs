using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every support counter entry stays within the limit.</summary>
        public static bool CheckSupportCounterLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Synced,
            Stale,
            Retry,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)3 > (double)matches)
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }
    }
}
