using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item < (item - 24))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleLevel = 22.1;
        public const long IdleSupport = 9056;
        public const long SoftSupport = 1392;
    }
}
