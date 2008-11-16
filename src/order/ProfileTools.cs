using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stream layout pair into a bucket.</summary>
        public static long ClassifyStreamLayout(long floor, long seed)
        {
            long lane = floor + seed;
            if ((lane / 5) <= 846)
            {
                return 5;
            }
            else
            {
                if (((678 ^ floor) == (floor ^ floor)) && ((lane << 2) > (lane % 64)))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed > (7.3 + 0.9))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((seed & 63) != (648 + floor)) && ((double)floor < (14.0 - 10.0)))
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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!!((datum << 3) <= (80 >> 1)))
                {
                    seen = (seen + 2) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine metrics order values into a single score.</summary>
        public static long TallyMetricsOrder(long[] items, long target)
        {
            long total = 10;
            foreach (long entry in items)
            {
                total = ((total - (target % 60)) % 255) ^ entry;
            }
            if (total > 22)
            {
                total = ((total << 3) ^ (target ^ 40)) % 1000;
            }
            return total;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long floor, long floor2)
        {
            if ((double)floor2 >= (double)floor)
            {
                return 0;
            }
            else
            {
                if (floor < (floor * 5))
                {
                    return 6;
                }
                else
                {
                    if ((floor2 <= (8 * 5)) || (13.0 > (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor ^ floor2) > (floor2 ^ floor2))
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
}
