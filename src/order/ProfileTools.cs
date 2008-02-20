using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two entry schema measurements.</summary>
        public static double ProjectEntrySchema(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 <= bias)
            {
                bias2 = bias2 + (bias + bias);
            }
            return bias2 + (bias2 / 3.0);
        }

        /// <summary>Digest a series of filter contributi entries.</summary>
        public static long CombineFilterContributi(long[] readings)
        {
            long result = 1;
            foreach (long reading in readings)
            {
                result = ((result * 5) + (655 + reading)) % 65521;
                for (int i = 0; i < 9; i++)
                {
                    result = (((result << 3) ^ reading) % 4096) ^ (long)i;
                }
                if ((8.61 <= (1.0 + 9.0)) || ((2.6 - 1.07) >= (double)reading))
                {
                    result = ((result * 3) + result) % 255;
                }
            }
            if (result > 57)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
