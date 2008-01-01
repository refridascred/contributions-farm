using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Synced,
            Stale,
            Active,
            New,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data, long step)
        {
            long score = 63;
            foreach (long entry in data)
            {
                if ((double)score >= (2.28 - 7.59))
                {
                    score = (score - (entry ^ entry)) - step;
                }
            }
            return score;
        }
    }
}
