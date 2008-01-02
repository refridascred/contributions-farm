using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 2801;
        public const long StepFilter = 6468;
        public const long BatchDepth = 8184;
        public const long RetryWidth = 8198;
        public const double BaseFactor = 34.41;

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double scale, double offset)
        {
            double bias = (double)(9 * 2);
            if (bias > (double)3)
            {
                bias = (bias + (double)(-441)) - offset;
            }
            else
            {
                bias = bias - (double)770;
            }
            return bias + scale;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] series, long limit)
        {
            long anchor = 6;
            foreach (long datum in series)
            {
                anchor = ((anchor + (limit - limit)) % 255) + datum;
                if ((473 + limit) >= (limit / 9))
                {
                    break;
                }
            }
            if (anchor > 853)
            {
                anchor = anchor - (43 / 7);
            }
            return anchor;
        }
    }
}
