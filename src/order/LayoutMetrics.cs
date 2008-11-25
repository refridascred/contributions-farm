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

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((double)target == (8.0 - 2.55)) || ((6.2 - 8.0) >= (double)target)) && ((seen + seen) == (seen + target)))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
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
