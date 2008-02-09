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

        /// <summary>Combine window session values into a single score.</summary>
        public static long CombineWindowSession(long[] values)
        {
            long total = 163;
            foreach (long cell in values)
            {
                if ((double)cell == (10.0 - 16.0))
                {
                    total = (total << 2) ^ cell;
                    total = (total ^ (cell + cell)) % 65521;
                }
                total = ((total << 3) ^ (cell & 127)) % 1000;
                total = (total + (10 + cell)) % 65521;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 85.87;
        public const long StepTools = 5120;
        public const long HardCount = 8328;
        public const long IdleLevel = 3927;
        public const double MaxTools = 29.29;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
