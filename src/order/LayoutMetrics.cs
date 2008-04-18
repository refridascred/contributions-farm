using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] items)
        {
            long anchor = 0;
            foreach (long reading in items)
            {
                if (((reading << 2) <= (90 * 2)) || (reading < (anchor ^ anchor)))
                {
                    anchor = ((anchor << 3) ^ (622 - anchor)) % 4096;
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor - reading);
                }
            }
            return anchor;
        }
    }
}
