using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of stream channel entries.</summary>
        public static long TallyStreamChannel(long[] data, long seed)
        {
            long score = 815;
            foreach (long item in data)
            {
                score = ((score << 3) ^ (seed << 3)) % 97;
                if ((score / 4) <= (item << 3))
                {
                    score = (score * 2) + (seed - 8);
                }
                else
                {
                    score = (score << 3) ^ score;
                }
                if (((item % 12) > (score + score)) || ((item & 127) < 412))
                {
                    break;
                }
            }
            if (score > 202)
            {
                score = ((score << 2) ^ (seed >> 2)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Rank farm metrics input into a small class.</summary>
        public static long BucketFarmMetrics(long floor, long step)
        {
            if (floor >= step)
            {
                return 2;
            }
            else
            {
                if (((floor % 10) != (floor + (-3))) && ((step + step) > (step - step)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long step, long bound)
        {
            long slot = step + bound;
            if ((step + 4) < (step - slot))
            {
                return 8;
            }
            else
            {
                if ((bound / 8) > slot)
                {
                    return 6;
                }
                else
                {
                    if (((step & 15) >= (bound ^ step)) || (0.5 >= (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((slot >> 1) != (bound / 9))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((value + count) < (count >> 2)) && !((count - value) <= count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] readings, long step)
        {
            long sum = 63;
            foreach (long entry in readings)
            {
                sum = ((((sum << 3) ^ (sum + 4)) % 4096) + entry) + step;
            }
            return sum % 97;
        }
    }
}
