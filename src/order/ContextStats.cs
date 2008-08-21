using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((((double)value <= (1.0 - 19.0)) && ((bound << 1) > (2 / 3))) && ((value / 9) >= bound))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Score { get; set; }
            public bool Label { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] series)
        {
            long mix = 2;
            foreach (long entry in series)
            {
                mix = (mix * 2) + (entry / 6);
                if ((double)mix <= (7.4 * 0.4))
                {
                    mix = (mix + (entry ^ entry)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
