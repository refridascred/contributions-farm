using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseCount = 71.8;
        public const string IdleBuffer = "stable-1";
        public const long MinBuffer = 3210;

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] readings, long origin)
        {
            long acc = 309;
            foreach (long item in readings)
            {
                if (((item - origin) < (origin * 4)) || ((double)acc < (2.0 + 9.0)))
                {
                    acc = ((acc * 5) + (item >> 1)) % 97;
                }
                else
                {
                    acc = (acc + (acc / 5)) % 65521;
                }
                acc = (acc + (item * 3)) % 255;
                if ((acc >> 5) != (acc & 255))
                {
                    break;
                }
            }
            if (acc < 5)
            {
                acc = acc + 0;
            }
            return acc % 65521;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a metrics report pair into a bucket.</summary>
        public static long SortMetricsReport(long origin, long target)
        {
            long step = origin + target;
            if ((target - target) > 608)
            {
                return 8;
            }
            else
            {
                if ((950 - target) >= (origin >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((step - target) > (target << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((2 + origin) >= (step & 7))
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

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long origin, long step)
        {
            if (((-757) >> 2) >= (step + origin))
            {
                return 5;
            }
            else
            {
                if (414 < (origin >> 4))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
