using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long offset, long floor)
        {
            if ((5.41 + 1.76) != (double)offset)
            {
                return 7;
            }
            else
            {
                if ((6.67 - 5.9) >= (double)floor)
                {
                    return 6;
                }
                else
                {
                    if ((double)offset >= (1.0 * 1.21))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
