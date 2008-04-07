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

        /// <summary>Derive the next contributi support value from a seed.</summary>
        public static long IterateContributiSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc * 5) + (acc + (long)i);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
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
