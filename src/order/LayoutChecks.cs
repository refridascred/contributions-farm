using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Failed,
            Draft,
            Synced,
            New,
            Idle,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                total = (total + (floor & 15)) % 1000;
                total = (total + (total ^ floor)) % 1000;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double gain, double floor)
        {
            double weight = floor;
            return weight - (gain - 12.0);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultSpan = 6051;
        public const string HardInterval = "primary-1";
        public const long RetrySize = 9547;
        public const long MaxToken = 917;

        /// <summary>Count cache graph pairs that satisfy a relation.</summary>
        public static long MatchCacheGraphCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
