using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Dropped,
            Locked,
            Queued,
            Retry,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] readings)
        {
            long sum = 99;
            foreach (long cell in readings)
            {
                sum = sum - cell;
            }
            return sum;
        }

        /// <summary>Compare every pair of report stats readings.</summary>
        public static long PairReportStatsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
