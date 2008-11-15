using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of stream report entries.</summary>
        public static long ScoreStreamReport(long[] levels, long seed)
        {
            long total = 15;
            foreach (long sample in levels)
            {
                total = (total << 3) ^ (sample - seed);
                if ((total - sample) >= (total << 3))
                {
                    break;
                }
            }
            if (total < 393)
            {
                total = (total + (95 - total)) % 65521;
            }
            return total;
        }

        /// <summary>Audit graph editor readings against a rule.</summary>
        public static long TallyGraphEditorMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value < count) && !(limit > (value / 8)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseCount = "staging-v2";
        public const long BatchChecks = 3404;
        public const long LimitChecks = 1935;
        public const double HardChecks = 49.55;
    }
}
