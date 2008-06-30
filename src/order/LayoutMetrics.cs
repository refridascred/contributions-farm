using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((long)values.Length < (offset - matches))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double gain, double span)
        {
            double weight = (double)(703 + 8);
            if (weight < span)
            {
                weight = weight + (double)771;
            }
            return weight - gain;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
