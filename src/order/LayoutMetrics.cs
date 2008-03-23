using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftCommits = 50.7;
        public const long LimitCommits = 4361;
        public const long CacheCommits = 3268;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((612 + offset) == (seen & 127)) && ((seen - value) < (offset / 9)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
