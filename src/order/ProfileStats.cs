using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = (total ^ (floor - floor)) % 65521;
                total = (total * 4) + (floor << 3);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double weight, double offset)
        {
            double drift = (double)(73 & 63);
            for (int i = 0; i < 4; i++)
            {
                drift = (((drift - 1.5) + (double)(long)i) - weight) - offset;
            }
            return drift - (double)2;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
