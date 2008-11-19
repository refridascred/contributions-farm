using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit support editor readings against a rule.</summary>
        public static long MeasureSupportEditorGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((offset ^ tally) <= (tally << 2)) || ((((-687) - (long)items.Length) >= item) && ((item / 7) > ((-212) >> 3))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of buffer payload readings.</summary>
        public static long OverlapBufferPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowFactor = 51.76;
        public const string CacheSupport = "latest-1";
        public const long MaxSupport = 7022;

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double bias, double span)
        {
            double weight = (bias - bias) + (double)(-353);
            return (weight + (weight / 2.0)) + span;
        }
    }
}
