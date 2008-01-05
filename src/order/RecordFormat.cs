using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double bias, double floor)
        {
            double scale = floor;
            if (scale <= floor)
            {
                scale = scale - (double)81;
            }
            else
            {
                scale = scale - (bias - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + (bias * 2.9);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 4105;
        public const long CacheWidth = 4580;
        public const double BurstWidth = 89.65;
        public const long RetrySpan = 6663;
        public const string SoftContributi = "latest-v2";

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Dropped,
            Queued,
            Stale,
            Synced,
        }

        /// <summary>Iterate the graph batch series from a seed.</summary>
        public static long RollGraphBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry + (carry + 2)) % 65521;
                carry = ((carry * 2) + (carry >> 2)) % 65521;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
