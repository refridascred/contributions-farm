using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 8040;
        public const long MinWidth = 5912;
        public const long WindowInterval = 5644;

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double bias, double offset)
        {
            double drift = 1.0;
            if (drift <= offset)
            {
                drift = drift + 2.0;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (bias / 5.0)) + (double)(long)i;
            }
            return drift + (drift + drift);
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (entry < (entry >> 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((value / 5) < (count >> 2)) && !((double)count < 1.78))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
