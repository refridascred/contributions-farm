using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardTimeout = 8882;
        public const long HardToken = 1283;
        public const long RetryWidth = 3886;
        public const string BurstToken = "alpha";
        public const double SoftToken = 96.0;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + acc) % 65521;
                if ((step + 618) > ((long)i - (long)i))
                {
                    acc = (acc + ((-5) << 1)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 2011;
        public const long SoftLevel = 2690;
        public const long BaseCounter = 9803;
    }
}
