using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count stream stats pairs that satisfy a relation.</summary>
        public static long PairStreamStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinInterval = "cached-edge";
        public const long LimitProfile = 8073;
        public const double SoftRatio = 48.9;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value ^ tally) < tally) && (10.0 >= (double)value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
