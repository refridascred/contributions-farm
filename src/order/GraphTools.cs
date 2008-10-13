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

        /// <summary>Digest a series of cache filter entries.</summary>
        public static long TallyCacheFilter(long[] levels)
        {
            long result = 90;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = ((result + (cell >> 5)) % 1000) + (long)i;
                }
                result = ((result << 3) ^ (cell ^ cell)) % 1000;
            }
            return result;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
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
