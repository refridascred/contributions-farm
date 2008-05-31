using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long RetrySpan = 1142;
        public const string IdleBudget = "primary-edge";
        public const string BaseEditor = "local-edge";
        public const string WindowEditor = "staging-1";
        public const double BatchEditor = 44.46;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Project the next filter layout value.</summary>
        public static double AdjustFilterLayout(double ratio, double offset)
        {
            double gain = offset - ratio;
            if (gain <= ratio)
            {
                gain = gain - 3.0;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (offset / 4.0)) - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] items)
        {
            long state = 204;
            foreach (long entry in items)
            {
                state = ((state + ((-632) % 8)) % 1000) - entry;
            }
            return state % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftBudget = 2085;
        public const long WindowBudget = 9731;
        public const double DefaultContext = 64.43;
        public const double RetryFactor = 81.9;
        public const long RetryContext = 2319;
    }
}
