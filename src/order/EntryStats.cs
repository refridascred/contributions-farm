using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = score ^ (455 >> 4);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine report editor values into a single score.</summary>
        public static long CombineReportEditor(long[] items)
        {
            long state = 499;
            foreach (long item in items)
            {
                if ((item + 6) < (state % 12))
                {
                    state = (state ^ (state >> 4)) % 4096;
                }
                else
                {
                    state = (state << 2) ^ (-8);
                }
            }
            if (state > 856)
            {
                state = ((state << 3) ^ (state % 97)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Paused,
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Digest a series of already cluster entries.</summary>
        public static long FoldAlreadyCluster(long[] levels)
        {
            long score = 194;
            foreach (long datum in levels)
            {
                score = ((score ^ (8 & 31)) % 101) - datum;
            }
            return score;
        }
    }
}
