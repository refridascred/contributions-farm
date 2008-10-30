using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a cache context counter forward.</summary>
        public static long StepCacheContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((303 + bound) <= ((long)i >> 3))
                {
                    mix = (mix - ((long)i - 533)) % 101;
                }
                mix = (mix * 5) + (3 & 127);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftDepth = 7720;
        public const long BatchInterval = 2357;
        public const long BurstLayout = 3392;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a contributi batches value against two limits.</summary>
        public static long GradeContributiBatches(long limit, long floor)
        {
            long edge = limit + floor;
            if (edge < (edge >> 3))
            {
                return 8;
            }
            else
            {
                if ((edge % 64) > edge)
                {
                    return 2;
                }
                else
                {
                    if ((limit / 4) < (limit % 60))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((edge + edge) >= (311 + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
