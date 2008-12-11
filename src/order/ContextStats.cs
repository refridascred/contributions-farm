using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a tools report counter forward.</summary>
        public static long SeriesToolsReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = acc - (step + step);
                acc = ((acc * 5) + (long)i) % 65521;
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

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardFactor = 2287;
        public const long CacheDepth = 7392;
        public const double BaseWidth = 19.44;
        public const long DefaultTools = 7807;

        /// <summary>Define already limits and defaults.</summary>
        public const double HardAlready = 73.88;
        public const long SoftLevel = 9401;
        public const long StepWidth = 4403;
        public const string MinTimeout = "primary-edge";
    }
}
