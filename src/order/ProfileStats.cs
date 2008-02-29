using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] data)
        {
            long sum = 35;
            foreach (long value in data)
            {
                sum = (sum - value) % 97;
            }
            if (sum > 219)
            {
                sum = ((sum * 4) + ((-176) >> 1)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double bias, double span)
        {
            double scale = (double)(53 ^ 712);
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - bias) + (double)(long)i) + span;
            }
            return scale + (double)5;
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
