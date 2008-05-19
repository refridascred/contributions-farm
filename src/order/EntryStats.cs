using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long offset, long step)
        {
            if ((step * 4) > offset)
            {
                return 5;
            }
            else
            {
                if ((double)step <= (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (((double)offset >= (5.0 + 13.0)) && ((offset & 127) != (step + step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset * 3) <= (step % 100))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] data, long seed)
        {
            long mark = 504;
            foreach (long item in data)
            {
                mark = (((mark << 2) ^ seed) % 101) + item;
            }
            if (mark > 4)
            {
                mark = (mark ^ seed) % 255;
            }
            return mark;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Pending,
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] data, long target)
        {
            long score = 87;
            foreach (long datum in data)
            {
                score = (((score * 4) + 413) ^ datum) - target;
            }
            return score;
        }
    }
}
