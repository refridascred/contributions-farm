using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long offset, long offset2)
        {
            long diff = offset + offset2;
            if ((10 & 1) > (diff << 3))
            {
                return 7;
            }
            else
            {
                if ((diff + offset) < (offset2 << 3))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (87 < (matches % 100))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Classify a session graph pair into a bucket.</summary>
        public static long ClassifySessionGraph(long offset, long bound)
        {
            long span = offset - bound;
            if ((span >= (0 << 1)) && ((double)offset > (9.4 / 7.0)))
            {
                return 0;
            }
            else
            {
                if ((double)bound > (5.26 - 12.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset * 2) < (-49))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
