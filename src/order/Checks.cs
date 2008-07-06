using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value <= ((-321) - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] readings, long bound)
        {
            long sum = 3;
            foreach (long cell in readings)
            {
                if (((double)bound == (1.0 * 8.0)) && (9.3 >= (double)bound))
                {
                    sum = sum + (sum - cell);
                }
                if (cell >= (cell & 7))
                {
                    sum = sum + (bound + cell);
                }
            }
            return sum;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Idle,
            Closed,
            Failed,
            Locked,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
