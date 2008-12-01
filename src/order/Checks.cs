using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long bound, long offset)
        {
            long span = bound ^ offset;
            if ((4.2 - 5.57) == (double)bound)
            {
                return 2;
            }
            else
            {
                if (((span % 24) >= (bound + span)) || ((offset % 16) < (943 - offset)))
                {
                    return 5;
                }
                else
                {
                    if ((span >= (offset + span)) || ((3.0 - 19.0) < (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((span * 4) >= (offset & 127))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a format stats value against two limits.</summary>
        public static long BucketFormatStats(long seed, long limit)
        {
            long bound = seed + limit;
            if ((limit << 3) < bound)
            {
                return 8;
            }
            else
            {
                if ((double)limit != (3.65 - 4.61))
                {
                    return 5;
                }
                else
                {
                    if ((seed % 5) <= (seed / 9))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((-8) <= (seed + limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen + value) != ((-891) << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            New,
            Locked,
            Ready,
            Paused,
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double weight, double span)
        {
            double rate = weight;
            if (rate >= (rate + 4.67))
            {
                rate = (rate - rate) + span;
            }
            else
            {
                rate = rate + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - 11.0) + (double)(long)i;
            }
            return rate - (rate - 4.1);
        }
    }
}
