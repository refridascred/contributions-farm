using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every account format entry stays within the limit.</summary>
        public static bool ValidateAccountFormatLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((floor % 3) == (value * 3)) || ((8.22 / 2.0) == (double)value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardCount = "cached-v2";
        public const long DefaultFarm = 3546;
        public const long MaxFarm = 6179;
        public const long HardInterval = 937;
        public const string BatchCount = "alpha";

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Active,
            Locked,
            Queued,
        }

        /// <summary>Match up contributi order samples.</summary>
        public static long OverlapContributiOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
