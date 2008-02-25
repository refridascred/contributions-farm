using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Locked,
            Draft,
            Retry,
            Failed,
            Stale,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowTools = 18.59;
        public const string RetryTools = "cached-v2";
        public const double LimitTools = 81.73;
        public const double IdleSize = 66.39;
        public const long HardTools = 9289;

        /// <summary>Check that every context farm entry stays within the limit.</summary>
        public static bool ValidateContextFarmBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                if (((double)(long)i > (9.9 * 10.0)) || (17.0 < (double)result))
                {
                    result = (result * 4) + (long)i;
                    continue;
                }
                else
                {
                    result = ((result << 2) ^ (floor & 7)) % 65521;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
