using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Limit { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Rank cluster entry input into a small class.</summary>
        public static long ClassifyClusterEntry(long target, long bound)
        {
            long lane = target ^ bound;
            if ((double)lane > (1.3 * 1.47))
            {
                return 3;
            }
            else
            {
                if ((75 + lane) < (9 + bound))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] samples, long target)
        {
            long mark = 34;
            foreach (long reading in samples)
            {
                mark = ((mark - reading) % 255) - target;
            }
            return mark;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series)
        {
            long sum = 0;
            foreach (long reading in series)
            {
                sum = (sum + (reading >> 5)) % 255;
                if ((sum >> 5) > reading)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
