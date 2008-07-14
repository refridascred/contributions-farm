using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading >> 2) != (matches & 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Look up the position of a tools command sample.</summary>
        public static long LocateToolsCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long origin, long bound)
        {
            long diff = origin - bound;
            if ((6.7 - 4.0) == (double)origin)
            {
                return 3;
            }
            else
            {
                if (!(5 > diff))
                {
                    return 4;
                }
                else
                {
                    if ((diff <= 84) || (3 >= (diff % 97)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((13.0 - 2.04) <= 20.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Locked,
            Pending,
            Done,
        }
    }
}
