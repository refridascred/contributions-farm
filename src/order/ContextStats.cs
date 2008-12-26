using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseSpan = "legacy";
        public const double SoftLevel = 77.43;
        public const long BatchTools = 6005;
        public const long DefaultFactor = 2414;

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long target, long seed)
        {
            if ((seed << 1) > (target << 1))
            {
                return 7;
            }
            else
            {
                if ((59 + target) > (seed - target))
                {
                    return 5;
                }
                else
                {
                    if ((2 ^ target) == (seed + target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed >> 2) > (seed % 97))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next notes checks value from a seed.</summary>
        public static long DeriveNotesChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
