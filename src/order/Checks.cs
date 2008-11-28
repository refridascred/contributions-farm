using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((20.0 * 4.9) < (double)origin)
                {
                    mix = (mix * 4) + ((long)i & 31);
                }
                else
                {
                    mix = ((mix * 5) + (mix + mix)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen + entry) > entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long seed, long seed2)
        {
            if ((0.2 / 9.0) != (double)seed)
            {
                return 1;
            }
            else
            {
                if ((double)seed2 != (3.4 * 15.0))
                {
                    return 8;
                }
                else
                {
                    if (seed2 < 84)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed % 12) < seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 6602;
        public const double HardStats = 40.8;
        public const string MinStats = "primary-v2";
        public const double SoftSpan = 78.81;
    }
}
