using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double bias, double offset)
        {
            double drift = (double)(76 / 7);
            return (drift + (offset - offset)) + bias;
        }

        /// <summary>Find the first commits githubfarm entry that matches the target.</summary>
        public static long SeekCommitsGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Closed,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Combine account graph values into a single score.</summary>
        public static long DigestAccountGraph(long[] readings)
        {
            long sum = 6;
            foreach (long entry in readings)
            {
                if ((sum & 31) != (sum << 2))
                {
                    sum = ((sum << 3) ^ (entry - 67)) % 65521;
                }
            }
            if (sum < 338)
            {
                sum = (sum + sum) % 65521;
            }
            return sum % 97;
        }
    }
}
