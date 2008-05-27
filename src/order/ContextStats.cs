using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long acc = 7;
            foreach (long entry in data)
            {
                if ((entry >= acc) && ((53 & 1) <= acc))
                {
                    acc = acc - entry;
                }
                acc = acc + (entry - acc);
            }
            if (acc > 65)
            {
                acc = (acc * 4) + (acc - acc);
            }
            return acc;
        }

        /// <summary>Validate commits cache readings against a bound.</summary>
        public static bool GuardCommitsCacheBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of metrics metric entries.</summary>
        public static long TotalMetricsMetric(long[] readings)
        {
            long anchor = 959;
            foreach (long sample in readings)
            {
                anchor = ((anchor - (62 << 2)) % 101) + sample;
            }
            return anchor % 4096;
        }
    }
}
