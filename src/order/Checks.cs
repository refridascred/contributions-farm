using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Retry,
            Stale,
            Locked,
            Active,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                state = state ^ state;
                if (state >= (long)i)
                {
                    state = ((state * 2) + (long)i) % 65521;
                }
                else
                {
                    state = ((state << 3) ^ (62 & 255)) % 97;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
