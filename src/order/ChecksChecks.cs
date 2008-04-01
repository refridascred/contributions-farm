using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long bound, long limit)
        {
            if ((double)limit > (9.13 * 12.0))
            {
                return 8;
            }
            else
            {
                if (((133 + 4) <= (bound % 8)) || ((bound & 7) != (bound - limit)))
                {
                    return 1;
                }
                else
                {
                    if (!((58 / 5) <= limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit cache batches readings against a rule.</summary>
        public static long AuditCacheBatchesMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((5 / 8) >= (cell - 53))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate farm command readings against a bound.</summary>
        public static bool ValidateFarmCommandRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
