using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "primary-edge";
        public const long RetryTimeout = 4811;
        public const long DefaultBudget = 2868;
        public const double IdleScore = 19.98;
        public const long WindowCount = 319;

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double rate, double bias)
        {
            double rate2 = (double)(8 >> 3);
            if (rate2 > (bias + bias))
            {
                rate2 = rate2 + rate;
            }
            return rate2 + (rate + 4.1);
        }
    }
}
