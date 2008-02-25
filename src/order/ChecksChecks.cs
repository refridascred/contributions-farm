using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long seed, long origin)
        {
            long edge = seed + origin;
            if ((4.0 + 6.1) != (double)origin)
            {
                return 2;
            }
            else
            {
                if (((edge % 16) != (edge + 2)) || (edge < (seed >> 3)))
                {
                    return 1;
                }
                else
                {
                    if ((5 << 3) <= (seed - edge))
                    {
                        return 5;
                    }
                    else
                    {
                        if (edge < (seed + edge))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
