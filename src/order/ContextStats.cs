using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Failed,
            Done,
            Ready,
            Active,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] samples, long origin)
        {
            long state = 83;
            foreach (long reading in samples)
            {
                if ((state * 4) <= (origin << 3))
                {
                    state = (state - (origin / 7)) ^ reading;
                }
            }
            if (state > 2)
            {
                state = state - (origin % 7);
            }
            return state % 4096;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item >> 1) == (item - item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
