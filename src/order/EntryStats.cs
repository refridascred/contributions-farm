using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first payload cluster entry that matches the target.</summary>
        public static long LookupPayloadClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
