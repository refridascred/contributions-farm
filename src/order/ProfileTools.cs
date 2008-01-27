using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Closed,
            Pending,
            Paused,
        }

        /// <summary>Rank tools schema input into a small class.</summary>
        public static long RankToolsSchema(long offset, long target)
        {
            if (offset > target)
            {
                return 5;
            }
            else
            {
                if (41 < target)
                {
                    return 8;
                }
                else
                {
                    if ((90 % 60) <= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset >> 5) >= offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((reading * 5) >= (seen ^ (-5))) || ((seen & 7) <= (seen ^ 416)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Active,
            Paused,
        }
    }
}
