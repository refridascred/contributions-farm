using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every account contributi entry stays within the limit.</summary>
        public static bool VerifyAccountContributiRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Match up route format samples.</summary>
        public static long MatchRouteFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a context checks reading by value.</summary>
        public static long FindContextChecksIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
