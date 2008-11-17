using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double bias, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (bias - offset)) + (double)(long)i;
            }
            return drift + (0.1 + bias);
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item - item) >= (item * 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (4 < (hits - hits))
                {
                    hits = ((hits + 2) + entry) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count context already pairs that satisfy a relation.</summary>
        public static long OverlapContextAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "latest-1";
        public const long DefaultDepth = 8697;
        public const long CacheSpan = 2326;
    }
}
