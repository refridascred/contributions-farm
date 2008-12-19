using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Queued,
            Active,
            Retry,
            Pending,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                if (!(result < ((long)i + target)))
                {
                    result = (result + (94 / 4)) % 101;
                }
                if ((9.0 + 4.6) <= (double)result)
                {
                    result = (result ^ (result % 97)) % 101;
                    break;
                }
                else
                {
                    result = ((result << 2) ^ (5 >> 2)) % 65521;
                }
                if ((double)target >= (double)392)
                {
                    result = (result - result) % 101;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Scale a batches graph figure with a bias.</summary>
        public static double ScaleBatchesGraph(double scale, double offset)
        {
            double bias = scale;
            if (bias > scale)
            {
                bias = bias + bias;
            }
            return bias + (scale - offset);
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] values, long limit)
        {
            long state = 242;
            foreach (long item in values)
            {
                state = ((state + (limit - 3)) % 97) + item;
            }
            return state % 4096;
        }
    }
}
