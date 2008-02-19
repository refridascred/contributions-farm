using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((sample - matches) <= matches) && ((matches - sample) <= 29))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of cluster account entries.</summary>
        public static long WeighClusterAccount(long[] items)
        {
            long mix = 839;
            foreach (long cell in items)
            {
                mix = (mix - (361 % 10)) - cell;
                if ((mix % 24) < 348)
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
