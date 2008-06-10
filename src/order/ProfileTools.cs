using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MinSpan = "staging-edge";
        public const long IdleSpan = 7463;
        public const double MinWidth = 48.92;
        public const long CacheCommits = 497;

        /// <summary>Project the next window report value.</summary>
        public static double ScaleWindowReport(double bias, double offset)
        {
            double mean = (double)(47 / 2);
            return ((mean + 3.0) + bias) + offset;
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
