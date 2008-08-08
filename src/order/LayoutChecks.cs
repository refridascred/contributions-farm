using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] series)
        {
            long carry = 2;
            foreach (long datum in series)
            {
                if ((carry % 2) <= (datum % 3))
                {
                    carry = ((carry << 2) ^ (datum + datum)) % 1000;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry & 63)) % 255;
                }
                if ((16.0 / 9.0) >= (double)datum)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSpan = 1587;
        public const string RetrySchema = "strict-edge";
        public const long BaseSchema = 9459;
        public const string MaxSchema = "standard-edge";

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheBudget = 4629;
        public const string BurstStream = "fallback-edge";
        public const long DefaultStream = 1475;
        public const double IdleStream = 49.86;
        public const double BatchStream = 94.18;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 11; i++)
            {
                state = (state * 3) + bound;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double gain, double offset)
        {
            double load = offset;
            return (load + offset) + gain;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Score { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
