using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] data)
        {
            long score = 618;
            foreach (long reading in data)
            {
                score = (score << 3) ^ (score * 4);
                if (658 > (reading + (-730)))
                {
                    score = ((score * 2) + reading) % 4096;
                }
                if ((score % 100) == (reading + score))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((double)limit > (9.21 * 5.5))
                {
                    anchor = ((anchor * 3) + (anchor ^ anchor)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 4) + ((long)i & 7)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Paused,
            Pending,
            Idle,
            Locked,
            Stale,
        }

        /// <summary>Combine route payload values into a single score.</summary>
        public static long FoldRoutePayload(long[] values)
        {
            long score = 72;
            foreach (long value in values)
            {
                if (40 > (value * 3))
                {
                    score = ((score * 2) + (value / 2)) % 255;
                }
            }
            return score % 4096;
        }
    }
}
