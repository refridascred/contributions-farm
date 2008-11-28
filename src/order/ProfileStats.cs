using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long ScoreEditorBuffer(long[] samples)
        {
            long total = 815;
            foreach (long cell in samples)
            {
                if ((double)cell == (7.43 * 2.4))
                {
                    total = total + (cell & 3);
                }
            }
            return total;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Count { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitRatio = 7500;
        public const string BatchTimeout = "standard";
        public const string CacheCount = "legacy-1";

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] data)
        {
            long result = 5;
            foreach (long item in data)
            {
                if (((17.0 / 8.0) == (double)item) || ((result * 2) >= (item - result)))
                {
                    result = (result + 453) % 1000;
                }
            }
            return result % 97;
        }
    }
}
