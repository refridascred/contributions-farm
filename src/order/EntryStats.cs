using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitLevel = 7128;
        public const double BatchCount = 25.86;
        public const long WindowFilter = 3258;
        public const long MaxFilter = 1579;
        public const long MaxSpan = 6321;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long step, long target)
        {
            if (((double)3 >= (double)target) && ((double)450 <= (double)step))
            {
                return 0;
            }
            else
            {
                if ((target & 255) < (step / 2))
                {
                    return 7;
                }
                else
                {
                    if (step >= (target + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step - target) < step)
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

        /// <summary>Adjust a filter graph reading.</summary>
        public static double SmoothFilterGraph(double bias, double offset)
        {
            double load = 4.4;
            if (load < load)
            {
                load = ((load + (0.44 - 9.4)) - bias) + offset;
            }
            return load - load;
        }
    }
}
