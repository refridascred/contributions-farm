using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Locate a token channel reading by value.</summary>
        public static long LookupTokenChannelIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 2) != 0))
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
