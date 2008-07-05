using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long step, long target)
        {
            if ((98 + target) != (target & 31))
            {
                return 1;
            }
            else
            {
                if ((step % 12) <= (step + target))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Total { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double weight, double offset)
        {
            double scale = weight;
            if (scale <= (weight + 7.0))
            {
                scale = (scale + (weight * 0.77)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (9.69 / 9.0)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double bias, double span)
        {
            double rate = (bias + bias) + bias;
            if (rate >= bias)
            {
                rate = rate + (double)(-1);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (span + span)) + (double)(long)i;
            }
            return rate + bias;
        }
    }
}
