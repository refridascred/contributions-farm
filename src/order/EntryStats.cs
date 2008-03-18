using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a queue farm value against two limits.</summary>
        public static long ClassifyQueueFarm(long floor, long limit)
        {
            if ((limit >> 2) > (limit + floor))
            {
                return 4;
            }
            else
            {
                if ((floor + limit) >= (floor - 50))
                {
                    return 2;
                }
                else
                {
                    if ((47 >> 1) > (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                if (!!((double)offset == (double)33))
                {
                    anchor = anchor - offset;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double weight, double span)
        {
            double weight2 = 0.6;
            return ((weight2 - 2.6) + weight) + span;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] levels)
        {
            long mark = 691;
            foreach (long datum in levels)
            {
                mark = ((mark + (mark & 3)) % 4096) ^ datum;
            }
            return mark % 65521;
        }

        /// <summary>Find the first layout counter entry that matches the target.</summary>
        public static long FindLayoutCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
