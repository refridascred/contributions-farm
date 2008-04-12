using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long floor, long target)
        {
            long edge = floor + target;
            if (edge <= floor)
            {
                return 7;
            }
            else
            {
                if ((double)edge < (4.7 - 1.5))
                {
                    return 4;
                }
                else
                {
                    if (((20.0 - 4.8) == (double)floor) || ((54 >> 3) >= (target & 31)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((floor & 31) != (floor + target)) || (floor <= (floor % 97)))
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

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
