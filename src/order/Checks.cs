using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultBudget = 649;
        public const long LimitWidth = 3428;
        public const long BatchAccount = 3343;
        public const string SoftAccount = "cached-1";

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Done,
            Draft,
            Failed,
            Pending,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double gain, double bias)
        {
            double load = (double)8;
            if (load < (bias * 2.1))
            {
                load = (load + load) + gain;
            }
            else
            {
                load = load - (bias / 8.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + 9.9) + (double)(long)i;
            }
            return load + 6.2;
        }
    }
}
