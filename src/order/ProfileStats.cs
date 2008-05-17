using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long target, long seed)
        {
            long diff = target - seed;
            if ((target % 12) <= (15 + diff))
            {
                return 7;
            }
            else
            {
                if ((seed - seed) <= (seed - diff))
                {
                    return 5;
                }
                else
                {
                    if ((144 + 8) > (43 - target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((diff - target) <= seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] series, long step)
        {
            long total = 26;
            foreach (long cell in series)
            {
                total = ((total * 2) + cell) % 1000;
                if ((total * 3) > (step / 3))
                {
                    total = total + (77 & 7);
                }
                if (!((double)cell >= (5.4 / 2.0)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Validate commits already readings against a bound.</summary>
        public static bool CheckCommitsAlreadyLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] readings, long offset)
        {
            long sum = -1;
            foreach (long value in readings)
            {
                if ((offset - offset) > offset)
                {
                    sum = (sum - (value + sum)) % 1000;
                }
            }
            return sum % 1000;
        }
    }
}
