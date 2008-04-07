using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((bound - 5) != (8 + bound))
                {
                    anchor = anchor - ((long)i / 8);
                }
                else
                {
                    anchor = (anchor * 3) + 560;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
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

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((((reading / 9) >= (tally >> 1)) || ((tally >> 1) >= (620 ^ (long)levels.Length))) && ((tally + 81) != (500 - 41)))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
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
