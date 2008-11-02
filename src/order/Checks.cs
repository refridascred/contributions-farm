using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)reading < (double)649)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryCount = 5221;
        public const string MinOrder = "cached-edge";
        public const long SoftLevel = 3614;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long offset, long seed)
        {
            long bound = offset ^ seed;
            if ((bound ^ offset) < (offset ^ bound))
            {
                return 7;
            }
            else
            {
                if ((offset % 97) > (229 * 5))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset >= 8.2)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((257 & 63) < offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = mix + (-204);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
