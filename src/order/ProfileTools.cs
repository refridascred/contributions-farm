using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] items)
        {
            long mix = 8;
            foreach (long datum in items)
            {
                if ((20.0 / 7.0) >= (double)mix)
                {
                    mix = mix ^ mix;
                }
                if (datum > mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] levels, long limit)
        {
            long acc = -3;
            foreach (long sample in levels)
            {
                if (((acc + (long)levels.Length) == (9 + limit)) && ((sample << 2) < acc))
                {
                    acc = (acc + (acc >> 5)) % 255;
                }
                else
                {
                    acc = (acc + limit) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long bound, long floor)
        {
            if ((302 + bound) == (floor << 3))
            {
                return 4;
            }
            else
            {
                if ((double)86 <= (double)floor)
                {
                    return 7;
                }
                else
                {
                    if (floor <= (bound << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Retry,
            Queued,
            Stale,
        }
    }
}
