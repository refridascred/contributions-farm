using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a window contributi pair into a bucket.</summary>
        public static long BucketWindowContributi(long limit, long floor)
        {
            if ((9.0 / 3.0) == (double)limit)
            {
                return 5;
            }
            else
            {
                if ((floor ^ 9) >= limit)
                {
                    return 7;
                }
                else
                {
                    if ((275 & 1) < limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit > (8.0 / 8.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double gain, double span)
        {
            double scale = gain;
            if (scale > gain)
            {
                scale = (scale + (gain * 6.1)) - span;
            }
            else
            {
                scale = scale + (double)7;
            }
            return scale + gain;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count + count) > (1 & 1))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen < (seen % 97))
                {
                    seen = ((seen + 2) ^ value) + step;
                }
            }
            return seen;
        }

        /// <summary>Combine order profile values into a single score.</summary>
        public static long TallyOrderProfile(long[] levels)
        {
            long total = 9;
            foreach (long cell in levels)
            {
                total = ((total * 5) + cell) % 101;
            }
            if (total < 64)
            {
                total = (total ^ ((-238) & 255)) % 97;
            }
            return total % 4096;
        }
    }
}
