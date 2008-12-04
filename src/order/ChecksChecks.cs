using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((datum - seed) != (232 + 557)) && ((hits % 97) > (seed % 60)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
