using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Done,
            New,
            Ready,
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            Active,
            New,
            Failed,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((count ^ (long)readings.Length) > count) && !((double)sample <= (double)772))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of support graph readings.</summary>
        public static long MatchSupportGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every layout metrics entry stays within the limit.</summary>
        public static bool GuardLayoutMetricsLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
