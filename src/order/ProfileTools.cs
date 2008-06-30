using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double IdleLevel = 91.85;
        public const long BurstOrder = 4983;
        public const long BaseSize = 5751;
        public const long BatchOrder = 6191;
        public const long BaseBudget = 7235;

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of order contributi readings.</summary>
        public static long PairOrderContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] series)
        {
            long sum = 9;
            foreach (long reading in series)
            {
                sum = (sum - 45) % 255;
                if ((reading % 12) >= (reading - sum))
                {
                    sum = ((sum * 3) + (reading << 3)) % 1000;
                }
                if ((7.07 / 6.0) < (double)reading)
                {
                    sum = ((sum << 2) ^ (reading % 12)) % 97;
                }
                else
                {
                    sum = (sum * 5) + (sum >> 5);
                }
            }
            return sum;
        }
    }
}
