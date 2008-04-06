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

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Ready,
            Done,
            Retry,
            Draft,
            Active,
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

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
