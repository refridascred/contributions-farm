using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Retry,
            Done,
            Idle,
            Active,
            Draft,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] data, long origin)
        {
            long sum = 6;
            foreach (long sample in data)
            {
                if (((139 >> 2) <= (sample + (long)data.Length)) || ((sum & 1) < (8 + sum)))
                {
                    sum = (sum - (origin << 2)) % 255;
                }
                sum = ((sum * 2) + sum) % 4096;
            }
            if (sum < (-61))
            {
                sum = (sum ^ sum) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample <= (double)665))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] items)
        {
            long acc = -53;
            foreach (long item in items)
            {
                acc = ((acc << 3) ^ (item % 2)) % 4096;
            }
            if (acc < 6)
            {
                acc = ((acc << 2) ^ 640) % 101;
            }
            return acc % 1000;
        }
    }
}
