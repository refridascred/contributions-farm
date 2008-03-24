using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Draft,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] values, long target)
        {
            long mark = 251;
            foreach (long reading in values)
            {
                long step = (target >> 5) - (reading ^ target);
                mark = mark - (step << 2);
                if (((double)mark == (double)reading) && ((reading + mark) != (target + mark)))
                {
                    mark = (mark ^ 8) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultSize = "cached-1";
        public const string SoftEditor = "strict-v2";
        public const long BatchEditor = 2078;
        public const double WindowScore = 73.43;
        public const long WindowDepth = 5485;
    }
}
