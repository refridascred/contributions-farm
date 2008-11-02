using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length >> 1) != (offset & 1))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long seed, long limit)
        {
            if (((2.0 + 4.0) > (double)seed) || ((limit + seed) >= (seed & 127)))
            {
                return 7;
            }
            else
            {
                if ((double)limit != (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((41 ^ limit) == (930 - 42))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit + seed) > (limit >> 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] items, long target)
        {
            long result = 59;
            foreach (long datum in items)
            {
                if ((double)result < (double)datum)
                {
                    result = (result - datum) + target;
                }
            }
            return result;
        }
    }
}
