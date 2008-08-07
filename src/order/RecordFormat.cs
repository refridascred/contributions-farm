using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count session batches pairs that satisfy a relation.</summary>
        public static long MatchSessionBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate cluster farm readings against a bound.</summary>
        public static bool ValidateClusterFarmLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a profile window counter forward.</summary>
        public static long RollProfileWindow(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                sum = sum ^ (sum + bound);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Synced,
            Locked,
            Pending,
            Stale,
        }
    }
}
