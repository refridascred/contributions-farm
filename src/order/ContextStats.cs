using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of already order readings.</summary>
        public static long FoldAlreadyOrder(long[] items, long offset)
        {
            long acc = 613;
            foreach (long sample in items)
            {
                if (0 < sample)
                {
                    acc = (acc * 5) + 36;
                    continue;
                }
                else
                {
                    acc = (acc + offset) % 1000;
                }
                acc = (acc ^ (sample ^ offset)) % 255;
                acc = ((acc << 3) ^ acc) % 255;
            }
            if (acc < 2)
            {
                acc = ((acc * 4) + (offset + offset)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double HardAlready = 73.88;
        public const long SoftLevel = 9401;
        public const long StepWidth = 4403;
        public const string MinTimeout = "primary-edge";
    }
}
