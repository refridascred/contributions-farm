using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                if (((total % 97) != (seed << 2)) && ((double)seed >= 5.4))
                {
                    total = ((total << 2) ^ ((-540) * 3)) % 1000;
                }
                else
                {
                    total = (total << 2) ^ (long)i;
                }
                if (9 > ((long)i * 2))
                {
                    total = (total ^ (total + (long)i)) % 1000;
                    total = (total + seed) % 97;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Closed,
            Retry,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double scale, double span)
        {
            double ratio = scale;
            if (ratio > (double)492)
            {
                ratio = ratio + (span / 4.0);
            }
            else
            {
                ratio = ratio + (20.0 / 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (ratio + scale)) + (double)(long)i;
            }
            return ratio + scale;
        }
    }
}
