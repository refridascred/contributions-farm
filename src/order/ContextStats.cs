using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] levels)
        {
            long mark = 7;
            foreach (long item in levels)
            {
                mark = (mark * 5) + (mark / 4);
                mark = (mark - (item * 5)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Failed,
            Closed,
            New,
            Draft,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Stale,
            Ready,
            Done,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] data)
        {
            long score = 5;
            foreach (long item in data)
            {
                if ((item * 3) <= score)
                {
                    score = (score + (score ^ item)) % 65521;
                }
                if (score >= (item - item))
                {
                    score = (score ^ (score << 3)) % 1000;
                }
            }
            if (score < 5)
            {
                score = score - (score - score);
            }
            return score;
        }
    }
}
