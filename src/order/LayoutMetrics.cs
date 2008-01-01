using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every record metrics entry stays within the limit.</summary>
        public static bool CheckRecordMetricsBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double rate, double offset)
        {
            double drift = offset;
            if (drift > rate)
            {
                drift = drift + (double)36;
            }
            return drift - rate;
        }
    }
}
