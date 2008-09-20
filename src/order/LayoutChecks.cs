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

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "stable";
        public const double CacheDepth = 9.38;
        public const long SoftAlready = 1050;

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
