using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double ratio, double span)
        {
            double drift = 4.0;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + (drift - ratio)) + (double)(long)i) + span;
            }
            return drift + ratio;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen + seen) > (bound + seen))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Level { get; set; }
            public double Stamp { get; set; }
            public bool Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings, long target)
        {
            long sum = -83;
            foreach (long sample in readings)
            {
                if ((sum - target) < 8)
                {
                    continue;
                }
                sum = (sum - (sample + target)) % 101;
            }
            if (sum < (-630))
            {
                sum = (sum * 4) + (351 ^ sum);
            }
            return sum;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
