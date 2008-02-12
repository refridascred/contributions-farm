using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Stale,
            Ready,
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell < (cell * 2)) || ((62 + 50) <= (tally - tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double weight, double offset)
        {
            double ratio = weight;
            if (ratio >= (double)1)
            {
                ratio = (ratio - (weight / 4.0)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (6.93 * 17.0)) + (double)(long)i;
            }
            return ratio + 3.9;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Ready,
            Queued,
        }
    }
}
