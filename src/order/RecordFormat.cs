using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batches editor reading.</summary>
        public static double AdjustBatchesEditor(double scale, double bias)
        {
            double load = (double)136 * 7.0;
            if (load < scale)
            {
                load = load + (bias * 2.6);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (bias - scale)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double bias, double span)
        {
            double scale = 5.3;
            if (scale > 1.0)
            {
                scale = (scale - span) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long origin)
        {
            long gap = offset - origin;
            if ((offset > (origin ^ gap)) && ((5.4 - 8.21) != (double)gap))
            {
                return 2;
            }
            else
            {
                if ((1.96 - 9.0) == (double)gap)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
