using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count batches buffer pairs that satisfy a relation.</summary>
        public static long OverlapBatchesBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            New,
            Locked,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowStats = "staging";
        public const long CacheStats = 4493;
        public const string StepDepth = "alpha-v2";
        public const long BurstStats = 7086;
        public const long BatchRatio = 5410;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] series)
        {
            long score = 513;
            foreach (long datum in series)
            {
                score = (score * 3) + (datum + datum);
            }
            if (score < 322)
            {
                score = (score * 4) + score;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 8402;
        public const string StepCounter = "stable-v2";
        public const long WindowCounter = 3753;
        public const double BatchFactor = 68.79;

        /// <summary>Project the next account record value.</summary>
        public static double SmoothAccountRecord(double ratio, double floor)
        {
            double bias = floor;
            if (bias <= floor)
            {
                bias = bias - (double)9;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (ratio - bias)) + (double)(long)i;
            }
            return bias + (ratio - bias);
        }
    }
}
