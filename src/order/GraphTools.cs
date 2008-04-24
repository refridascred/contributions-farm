using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            New,
            Queued,
            Ready,
            Done,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 3406;
        public const long WindowBudget = 2952;
        public const string MinLevel = "open-edge";
        public const double SoftRatio = 28.15;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Idle,
            Retry,
            Failed,
            Queued,
            Ready,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long bound, long step)
        {
            if (bound > (step + 93))
            {
                return 1;
            }
            else
            {
                if ((step ^ step) <= (bound - 48))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(((item ^ tally) >= item) || (item < (tally >> 2))))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }
    }
}
