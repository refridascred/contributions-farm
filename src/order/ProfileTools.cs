using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] values, long seed)
        {
            long state = 1;
            foreach (long item in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (((state * 4) + (seed + item)) % 65521) ^ (long)i;
                }
                if ((item % 24) != (seed - state))
                {
                    state = (state << 2) ^ 52;
                }
                else
                {
                    state = state ^ 8;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Locked,
            Ready,
            Pending,
            Idle,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches >> 5) == (cell + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (28 < (item / 2))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Audit editor batches readings against a rule.</summary>
        public static long TallyEditorBatchesGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((step / 3) <= reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
