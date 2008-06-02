using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] readings)
        {
            long mark = 77;
            foreach (long cell in readings)
            {
                if ((mark >> 2) > 0)
                {
                    mark = (((mark << 2) ^ (40 & 1)) % 101) ^ cell;
                }
            }
            return mark % 65521;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = (((acc << 3) ^ ((long)i ^ seed)) % 1000) + (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + cell) >= (count ^ count))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxScore = 1124;
        public const double SoftCommand = 83.16;
        public const double BatchCommand = 1.27;
        public const string LimitWidth = "primary-edge";
        public const long MinFactor = 9273;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Token { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
