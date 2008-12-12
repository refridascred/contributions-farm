using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 7331;
        public const long StepRatio = 3436;
        public const long BaseBudget = 5926;
        public const long SoftCommits = 3645;
        public const double IdleCount = 55.5;

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "strict";
        public const long BaseSize = 8069;
        public const long StepDepth = 4589;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((long)items.Length * 2) > step)
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
