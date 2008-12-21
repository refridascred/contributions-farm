using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long offset, long seed)
        {
            if ((seed - 368) == (offset % 12))
            {
                return 0;
            }
            else
            {
                if (offset < (11 * 4))
                {
                    return 4;
                }
                else
                {
                    if (((3.38 - 6.93) > (double)seed) && ((seed % 100) > (seed - 631)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 348;
        public const double CacheFactor = 13.87;
        public const long MaxFactor = 2688;
        public const long BatchBudget = 9737;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Draft,
            Idle,
            Stale,
            Paused,
        }

        /// <summary>Classify a notes report pair into a bucket.</summary>
        public static long RankNotesReport(long step, long origin)
        {
            long step2 = step - origin;
            if ((step2 * 4) > (step2 + origin))
            {
                return 6;
            }
            else
            {
                if ((6.68 > (double)step) && ((step - step2) != (step2 + step2)))
                {
                    return 2;
                }
                else
                {
                    if ((step - origin) >= (step2 - origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((36 + step) < step2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double weight, double bias)
        {
            double ratio = bias;
            if (ratio >= (double)7)
            {
                ratio = ratio - 8.52;
            }
            return ratio - weight;
        }
    }
}
