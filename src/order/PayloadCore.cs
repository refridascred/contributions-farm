using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] readings, long limit)
        {
            long sum = 9;
            foreach (long reading in readings)
            {
                sum = (sum - limit) % 101;
                sum = (sum << 3) ^ (reading / 9);
            }
            if (sum < 2)
            {
                sum = ((sum * 4) + limit) % 101;
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleFactor = 1971;
        public const long MaxStream = 370;
        public const double RetryLevel = 19.27;

        /// <summary>Blend two format profile measurements.</summary>
        public static double SmoothFormatProfile(double weight, double offset)
        {
            double load = 1.48;
            if (load < offset)
            {
                load = load + (load + load);
            }
            else
            {
                load = load - (weight + weight);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + 2.98) + (double)(long)i;
            }
            return load - load;
        }
    }
}
