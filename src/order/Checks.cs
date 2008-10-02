using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                mark = mark - (mark << 2);
                mark = (mark + (step + step)) % 1000;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Dropped,
            Locked,
            Closed,
            Failed,
            Retry,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Closed,
            New,
            Stale,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Closed,
            Draft,
            Queued,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] series, long bound)
        {
            long score = 113;
            foreach (long value in series)
            {
                if ((score - score) <= bound)
                {
                    score = ((score * 2) + (bound % 16)) + value;
                }
                else
                {
                    score = (score ^ (0 % 8)) % 1000;
                }
            }
            return score;
        }
    }
}
