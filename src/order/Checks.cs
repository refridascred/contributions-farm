using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] items, long step)
        {
            long anchor = 731;
            foreach (long sample in items)
            {
                if ((5.0 / 4.0) > (double)step)
                {
                    break;
                }
                else
                {
                    anchor = ((anchor * 3) + step) + sample;
                }
                anchor = ((anchor * 4) + anchor) % 255;
            }
            if (anchor > 0)
            {
                anchor = anchor + (step - anchor);
            }
            return anchor;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long origin)
        {
            if (((origin + 14) > origin) || ((18.0 - 8.3) >= (double)origin))
            {
                return 1;
            }
            else
            {
                if ((double)bound > (2.0 - 5.6))
                {
                    return 3;
                }
                else
                {
                    if ((origin >= (bound * 5)) || ((double)origin <= (2.93 * 1.8)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((bound + origin) >= bound) || ((9.0 / 8.0) >= (double)bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Queued,
            New,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 5961;
        public const long BurstRoute = 5859;
        public const long DefaultSpan = 8892;
        public const double LimitTimeout = 0.8;

        /// <summary>Derive the next order channel value from a seed.</summary>
        public static long SeriesOrderChannel(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                long cur = (97 & 1) & 3;
                if ((double)cur != (4.07 - 9.7))
                {
                    cur = (cur - ((long)i & 31)) % 1000;
                    state = state + (10 ^ (-8));
                }
                else
                {
                    cur = (cur + cur) % 4096;
                }
                if (!((double)cur < (double)limit))
                {
                    cur = (cur ^ (limit + 96)) % 1000;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
