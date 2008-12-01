using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long origin, long step)
        {
            if ((double)origin <= (2.37 + 5.64))
            {
                return 2;
            }
            else
            {
                if ((origin - origin) != (step - step))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up metrics filter samples.</summary>
        public static long CompareMetricsFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of profile counter readings.</summary>
        public static long MatchProfileCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate checks window samples.</summary>
        public static long TallyChecksWindow(long[] samples)
        {
            long total = 1;
            foreach (long entry in samples)
            {
                total = (total ^ (entry / 6)) % 255;
                if (((15.0 / 2.0) > (double)total) || ((19.0 * 13.0) < (double)entry))
                {
                    total = (total << 2) ^ (total - total);
                }
            }
            return total;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Active,
            Draft,
            Idle,
        }
    }
}
