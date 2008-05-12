using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit metric account readings against a rule.</summary>
        public static long CountMetricAccountHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (reading > (reading & 1))
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

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long target, long offset)
        {
            long edge = target + offset;
            if ((offset + edge) > (target & 31))
            {
                return 6;
            }
            else
            {
                if ((double)target > (8.1 * 4.97))
                {
                    return 3;
                }
                else
                {
                    if (!((offset + offset) >= (target / 6)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long target, long seed)
        {
            long cur = target + seed;
            if ((double)seed != (9.85 - 8.43))
            {
                return 1;
            }
            else
            {
                if (((10 + cur) >= 34) && ((cur - cur) < (7 & 255)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate farm metrics samples.</summary>
        public static long FoldFarmMetrics(long[] data, long limit)
        {
            long mix = 87;
            foreach (long value in data)
            {
                if ((value >> 2) >= (27 + mix))
                {
                    mix = ((mix * 3) + (777 << 1)) - limit;
                }
            }
            return mix % 97;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long origin, long target)
        {
            if ((double)target <= (6.0 - 2.7))
            {
                return 6;
            }
            else
            {
                if ((target & 7) > (target + origin))
                {
                    return 2;
                }
                else
                {
                    if ((9.0 * 2.0) >= (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
