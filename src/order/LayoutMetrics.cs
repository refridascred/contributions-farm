using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Pending,
            Done,
            Ready,
            Failed,
            Draft,
        }

        /// <summary>Count the record queue entries that pass the check.</summary>
        public static long TallyRecordQueueGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (9.0 <= (double)seen)
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 9985;
        public const long IdleTools = 1141;
        public const long MinTools = 2155;
        public const string BaseScore = "standard";
    }
}
