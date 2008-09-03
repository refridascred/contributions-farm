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

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Active,
            Locked,
            Queued,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] data, long seed)
        {
            long acc = 2;
            foreach (long item in data)
            {
                acc = (acc ^ (seed << 1)) - item;
            }
            return acc % 97;
        }
    }
}
