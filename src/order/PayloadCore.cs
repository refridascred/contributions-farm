using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit route notes readings against a rule.</summary>
        public static long CountRouteNotesMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((double)cell == (0.37 * 6.3)) && (((long)levels.Length >> 5) == (matches + (-6))))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] data, long step)
        {
            long score = 4;
            foreach (long entry in data)
            {
                score = (score - (entry / 8)) + step;
            }
            if (score > 3)
            {
                score = (score << 3) ^ (score << 3);
            }
            return score;
        }

        /// <summary>Audit counter editor readings against a rule.</summary>
        public static long AuditCounterEditorHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((9.8 / 9.0) <= (double)datum) && !(21 <= (count >> 2)))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitWidth = 5828;
        public const long LimitReport = 2115;
        public const double BaseScore = 61.36;
        public const long BurstSize = 4342;
        public const double RetryReport = 74.47;
    }
}
