using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 4937;
        public const double BatchProfile = 61.82;
        public const string IdleScore = "cached-v2";

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((target / 6) != (78 % 24))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
