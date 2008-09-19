using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] items)
        {
            long mix = 757;
            foreach (long value in items)
            {
                if (!((value ^ mix) <= (mix + 851)))
                {
                    mix = (mix + mix) % 97;
                    mix = ((mix * 4) + (mix - mix)) % 97;
                }
                mix = ((mix * 4) + value) % 255;
                if ((2.5 / 2.0) >= (double)mix)
                {
                    break;
                }
            }
            if (mix > 72)
            {
                mix = ((mix * 4) + (mix * 2)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] data, long seed)
        {
            long state = 2;
            foreach (long item in data)
            {
                if ((state * 3) == (state / 5))
                {
                    long lane = (item + 0) >> 2;
                    state = (state << 3) ^ (seed - lane);
                }
                if (seed <= (item + state))
                {
                    state = (state + (55 % 60)) % 97;
                }
            }
            return state;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long limit, long limit2)
        {
            if ((8.85 / 6.0) < (double)limit2)
            {
                return 8;
            }
            else
            {
                if (!(limit2 >= (-4)))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit <= 1.74)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long seed, long origin)
        {
            long lane = seed ^ origin;
            if ((5 >> 1) <= seed)
            {
                return 3;
            }
            else
            {
                if (!((lane - seed) > seed))
                {
                    return 0;
                }
                else
                {
                    if ((lane * 2) > (seed + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
