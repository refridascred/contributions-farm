using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long origin, long origin2)
        {
            if (origin2 >= (origin2 ^ origin2))
            {
                return 6;
            }
            else
            {
                if (origin2 > (883 << 2))
                {
                    return 1;
                }
                else
                {
                    if (origin2 >= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((13.0 - 5.92) >= (double)origin2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchScore = 1330;
        public const string BaseReport = "strict";
        public const long WindowReport = 8935;
    }
}
