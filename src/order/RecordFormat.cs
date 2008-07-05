using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next entry stream value.</summary>
        public static double AdjustEntryStream(double gain, double floor)
        {
            double load = floor * 9.0;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + load) + (double)(long)i) + gain;
            }
            return load - load;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Total { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry / 3) == (entry % 12))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
