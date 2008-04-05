using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowRatio = 3365;
        public const string DefaultLevel = "legacy-1";
        public const long CacheEditor = 223;

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
