using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double ratio, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + bias) + (double)(long)i) - ratio;
            }
            return gain - (double)542;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 6574;
        public const long RetryBudget = 9112;
        public const long HardChecks = 1140;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
