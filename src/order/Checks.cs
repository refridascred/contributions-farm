using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                result = (result << 2) ^ (result / 6);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every layout stats entry stays within the limit.</summary>
        public static bool ValidateLayoutStatsLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Done,
            Ready,
            New,
            Active,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Retry,
            Pending,
            Ready,
            Paused,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Retry,
            Failed,
            Paused,
            Draft,
        }
    }
}
