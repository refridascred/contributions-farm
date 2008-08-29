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

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long origin, long offset)
        {
            long span = origin + offset;
            if ((4.23 / 7.0) < (double)origin)
            {
                return 5;
            }
            else
            {
                if ((span >> 1) >= (origin % 60))
                {
                    return 1;
                }
                else
                {
                    if ((offset / 3) >= span)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((span % 7) >= (span >> 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
