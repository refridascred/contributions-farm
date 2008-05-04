using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 1518;
        public const long IdleScore = 5618;
        public const long IdleRatio = 5894;
        public const string WindowRatio = "latest-edge";
        public const long MaxSchema = 4696;

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data, long limit)
        {
            long carry = 280;
            foreach (long item in data)
            {
                carry = ((carry + limit) % 255) - item;
            }
            return carry;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a buffer stats reading.</summary>
        public static double SmoothBufferStats(double rate, double floor)
        {
            double ratio = 5.1 / 3.0;
            if (ratio >= (13.0 * 9.9))
            {
                ratio = ratio + 6.27;
            }
            else
            {
                ratio = ratio - (floor - ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio + rate;
        }
    }
}
