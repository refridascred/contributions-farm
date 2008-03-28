using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] series, long floor)
        {
            long carry = 8;
            foreach (long cell in series)
            {
                carry = ((carry - (carry - (long)series.Length)) % 97) - cell;
                carry = (carry * 5) + ((-7) * 4);
            }
            if (carry < 87)
            {
                carry = ((carry * 5) + (floor * 3)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 2035;
        public const long HardSize = 2305;
        public const string WindowBuffer = "standard-edge";

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double ratio, double bias)
        {
            double scale = ratio / 4.0;
            return scale + (bias + bias);
        }
    }
}
