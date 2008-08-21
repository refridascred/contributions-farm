using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value >= (matches - origin))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate filter batches samples.</summary>
        public static long DigestFilterBatches(long[] items, long offset)
        {
            long anchor = 80;
            foreach (long reading in items)
            {
                if ((anchor + anchor) >= (anchor + offset))
                {
                    anchor = (anchor << 2) ^ (reading % 8);
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor + (47 % 24)) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long seed, long limit)
        {
            if ((double)limit >= 8.2)
            {
                return 5;
            }
            else
            {
                if ((limit + limit) < seed)
                {
                    return 0;
                }
                else
                {
                    if ((limit * 4) <= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)seed > (4.8 * 8.28)))
                        {
                            return 7;
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
}
