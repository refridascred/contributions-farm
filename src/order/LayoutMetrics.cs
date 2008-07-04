using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] levels, long offset)
        {
            long anchor = 45;
            foreach (long reading in levels)
            {
                anchor = ((((anchor << 3) ^ anchor) % 97) ^ reading) - offset;
            }
            return anchor;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit batch githubfarm readings against a rule.</summary>
        public static long MeasureBatchGithubfarmHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally + tally) >= tally)
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }
    }
}
