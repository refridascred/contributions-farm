using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double gain, double floor)
        {
            double bias = (double)(87 / 4);
            if (bias <= (gain - floor))
            {
                bias = bias + (14.0 * 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (double)28) + (double)(long)i;
            }
            return bias - (double)9;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long offset, long target)
        {
            if ((offset * 5) > (target + target))
            {
                return 3;
            }
            else
            {
                if (((offset & 255) > offset) && (target <= (offset << 1)))
                {
                    return 2;
                }
                else
                {
                    if (((target * 5) < offset) && ((7.0 + 4.29) != (double)offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Weight { get; set; }
            public double Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long offset, long step)
        {
            if (((double)step == (3.45 - 5.0)) || ((offset - offset) != (step % 97)))
            {
                return 2;
            }
            else
            {
                if ((offset * 2) > step)
                {
                    return 8;
                }
                else
                {
                    if (((9.9 - 6.0) < (double)offset) && (step > 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset << 2) >= offset) && (offset <= (step & 255)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheScore = "open";
        public const string SoftCluster = "stable-v2";
        public const double RetryLevel = 62.8;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Idle,
            Active,
            Failed,
        }
    }
}
