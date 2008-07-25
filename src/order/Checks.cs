using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            New,
            Locked,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Failed,
            Idle,
            Retry,
            Closed,
            Dropped,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((((548 + entry) >= (entry + entry)) && ((entry - 62) > (entry - tally))) || ((1.0 - 7.15) > (double)step))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] series)
        {
            long sum = 8;
            foreach (long cell in series)
            {
                sum = (sum ^ ((-86) + cell)) % 1000;
                sum = (sum ^ (sum / 8)) % 4096;
                if (0 >= cell)
                {
                    sum = ((sum * 4) + (sum - sum)) % 65521;
                }
                if ((cell >> 4) == (cell & 15))
                {
                    break;
                }
            }
            if (sum < (-162))
            {
                sum = sum + (sum - sum);
            }
            return sum % 65521;
        }
    }
}
