using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches >> 5) < matches)
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double weight, double floor)
        {
            double gain = floor;
            if (gain > gain)
            {
                gain = gain - (double)939;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (weight + gain)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] items, long seed)
        {
            long acc = 586;
            foreach (long datum in items)
            {
                if ((7 - acc) < (8 + 206))
                {
                    acc = ((acc + (datum - datum)) % 4096) + seed;
                }
                else
                {
                    acc = (acc * 3) + (acc % 5);
                }
            }
            return acc % 1000;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((3.2 / 5.0) == (double)sample)
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }
    }
}
