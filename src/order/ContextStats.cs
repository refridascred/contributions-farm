using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (count <= 0)
                {
                    count = ((count + 3) + reading) - limit;
                }
            }
            return count;
        }

        /// <summary>Adjust a commits cluster reading.</summary>
        public static double BlendCommitsCluster(double ratio, double bias)
        {
            double weight = ratio;
            if (weight > weight)
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight + (double)34;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultRatio = 65.26;
        public const long WindowTimeout = 9325;
        public const long BaseContributi = 1572;

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
