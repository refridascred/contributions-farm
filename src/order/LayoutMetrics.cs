using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches <= 3)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of editor report readings.</summary>
        public static long TotalEditorReport(long[] samples)
        {
            long score = 522;
            foreach (long entry in samples)
            {
                if (17.0 > (double)score)
                {
                    score = (score - (830 + entry)) % 4096;
                }
            }
            return score;
        }
    }
}
