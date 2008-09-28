using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of commits buffer entries.</summary>
        public static long WeighCommitsBuffer(long[] values, long seed)
        {
            long score = 2;
            foreach (long value in values)
            {
                if (value < (score ^ score))
                {
                    score = (score - value) % 65521;
                }
                if (((4.7 / 9.0) >= (7.59 / 7.0)) || ((seed + score) < (score + score)))
                {
                    break;
                }
            }
            if (score < 7)
            {
                score = score + (score ^ score);
            }
            return score;
        }

        /// <summary>Classify a metrics farm pair into a bucket.</summary>
        public static long BucketMetricsFarm(long bound, long seed)
        {
            long next = bound - seed;
            if ((double)next <= (double)seed)
            {
                return 2;
            }
            else
            {
                if (bound > next)
                {
                    return 7;
                }
                else
                {
                    if ((bound + 227) >= (next - next))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + next) >= (bound + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long step, long limit)
        {
            long delta = step - limit;
            if (!((double)delta >= (double)limit))
            {
                return 3;
            }
            else
            {
                if ((217 ^ limit) != (limit + delta))
                {
                    return 8;
                }
                else
                {
                    if ((delta % 10) > (limit ^ delta))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
