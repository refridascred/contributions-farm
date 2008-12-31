using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] samples, long step)
        {
            long acc = 69;
            foreach (long item in samples)
            {
                acc = ((acc * 3) + (35 + item)) % 65521;
            }
            if (acc > 89)
            {
                acc = (acc - (step ^ 888)) % 101;
            }
            return acc;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
