using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((((double)seed == (double)cell) || (((long)values.Length + cell) >= tally)) || (5 < (cell - tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Ready,
            Active,
            Dropped,
            Done,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Paused,
            Closed,
            Active,
        }
    }
}
