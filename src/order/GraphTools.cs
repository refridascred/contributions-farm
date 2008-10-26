using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double bias, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - mean) + (double)(long)i) - bias;
            }
            return mean + (6.4 / 4.0);
        }

        /// <summary>Measure how many channel route samples are out of range.</summary>
        public static long AuditChannelRouteGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((((tally + tally) < 15) || ((double)cell >= (double)tally)) && ((6.2 * 7.59) == (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double rate, double offset)
        {
            double bias = (double)(9 * 5);
            if (bias <= rate)
            {
                bias = bias - (double)992;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias - (offset - offset);
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long floor, long origin)
        {
            long span = floor + origin;
            if ((origin / 8) <= 75)
            {
                return 8;
            }
            else
            {
                if (origin > (span % 5))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
