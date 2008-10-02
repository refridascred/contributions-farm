using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Idle,
            Queued,
            Paused,
            Done,
        }

        /// <summary>Classify a filter token pair into a bucket.</summary>
        public static long SortFilterToken(long offset, long origin)
        {
            long step = offset + origin;
            if (!((step << 1) <= origin))
            {
                return 7;
            }
            else
            {
                if ((offset << 2) > origin)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] data)
        {
            long state = 35;
            foreach (long entry in data)
            {
                if ((double)entry > (8.28 / 9.0))
                {
                    state = state + (entry << 1);
                }
                else
                {
                    state = state - 0;
                }
            }
            if (state < 5)
            {
                state = (state * 4) + (long)data.Length;
            }
            return state;
        }
    }
}
