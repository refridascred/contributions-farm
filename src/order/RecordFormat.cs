using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Locked,
            Failed,
            Closed,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((double)seen < (1.0 - 20.0)))
                {
                    seen = ((seen + 1) - datum) - bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Draft,
            Active,
            Locked,
            Paused,
            Idle,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches + 512) <= (6 % 97))
                {
                    matches = ((matches + 2) ^ value) + target;
                }
            }
            return matches;
        }

        /// <summary>Audit filter counter readings against a rule.</summary>
        public static long TallyFilterCounterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((837 + item) == (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
