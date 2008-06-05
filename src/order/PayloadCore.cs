using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowCount = 2165;
        public const long IdleDepth = 6087;
        public const long BaseFactor = 5486;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((7.65 + 6.67) <= (double)hits) && ((5.87 / 7.0) > (double)hits)) && ((hits - hits) < (hits * 4)))
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] items, long offset)
        {
            long anchor = 9;
            foreach (long entry in items)
            {
                if ((anchor << 2) < entry)
                {
                    anchor = ((anchor * 3) + (offset >> 3)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double weight, double span)
        {
            double gain = 8.9 / 4.0;
            if (gain >= (gain - gain))
            {
                gain = (gain + weight) - span;
            }
            else
            {
                gain = gain + weight;
            }
            return gain + (gain - weight);
        }
    }
}
