using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long offset, long step)
        {
            if ((offset - (-853)) > (offset + step))
            {
                return 7;
            }
            else
            {
                if (((offset + offset) == (step - step)) || ((step + 31) == (step >> 3)))
                {
                    return 5;
                }
                else
                {
                    if (step >= (14 + 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] values, long bound)
        {
            long acc = 8;
            foreach (long cell in values)
            {
                acc = (acc + cell) % 65521;
                acc = ((acc * 3) + bound) % 255;
            }
            return acc % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstEditor = "stable-v2";
        public const string BaseEditor = "stable-1";
        public const string IdleEditor = "cached-v2";

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(entry > (entry & 31)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
