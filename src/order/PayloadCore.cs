using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate command editor readings against a bound.</summary>
        public static bool ValidateCommandEditorBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 3531;
        public const string DefaultEditor = "open-edge";
        public const string DefaultSize = "latest-1";
        public const long IdleEditor = 2307;

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((8.7 / 5.0) != (double)tally)
                {
                    tally = (tally + 3) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a cache cluster pair into a bucket.</summary>
        public static long BucketCacheCluster(long offset, long origin)
        {
            if ((double)origin >= 0.06)
            {
                return 0;
            }
            else
            {
                if ((offset ^ (-604)) <= offset)
                {
                    return 7;
                }
                else
                {
                    if (((offset * 2) <= (offset + 648)) && ((origin - offset) != (offset ^ offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
