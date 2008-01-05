using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Queued,
            Done,
            Retry,
            Pending,
        }

        /// <summary>Rank account cache input into a small class.</summary>
        public static long BucketAccountCache(long offset, long floor)
        {
            long cur = offset ^ floor;
            if ((540 >= (floor ^ offset)) || (((-755) + offset) > (cur >> 1)))
            {
                return 6;
            }
            else
            {
                if ((offset * 4) != (cur % 2))
                {
                    return 3;
                }
                else
                {
                    if ((2 + floor) >= (offset + cur))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((8.0 * 9.0) == (double)offset) || ((floor + 6) > 91))
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

        /// <summary>Grade a notes token value against two limits.</summary>
        public static long GradeNotesToken(long offset, long seed)
        {
            if (!((double)offset != (14.0 + 19.0)))
            {
                return 6;
            }
            else
            {
                if ((double)(-72) != (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (offset < (145 - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double ratio, double span)
        {
            double weight = (span / 7.0) - ratio;
            return weight + (16.0 - ratio);
        }

        /// <summary>Combine batches editor values into a single score.</summary>
        public static long DigestBatchesEditor(long[] levels, long target)
        {
            long result = -7;
            foreach (long cell in levels)
            {
                if (!((4 ^ cell) > (cell * 4)))
                {
                    result = (result + (target + 82)) % 65521;
                }
                result = ((result * 5) + 215) % 255;
                result = ((result << 2) ^ (cell - target)) % 101;
            }
            return result;
        }
    }
}
