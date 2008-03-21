using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 8919;
        public const string BatchSize = "latest-edge";
        public const double MinPayload = 76.47;

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double ratio, double offset)
        {
            double rate = ratio;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - 9.7) - (double)(long)i) + offset;
            }
            return rate - rate;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((double)floor <= (double)total)
                {
                    total = (total ^ (total % 97)) % 101;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
