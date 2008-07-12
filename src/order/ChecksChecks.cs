using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            New,
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long sum = 61;
            foreach (long datum in readings)
            {
                if (!((sum + 8) != (datum << 1)))
                {
                    sum = (sum - (sum + 529)) % 97;
                }
            }
            if (sum > 98)
            {
                sum = (sum ^ (sum & 3)) % 255;
            }
            return sum;
        }

        /// <summary>Check that every commits stats entry stays within the limit.</summary>
        public static bool ValidateCommitsStatsLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
