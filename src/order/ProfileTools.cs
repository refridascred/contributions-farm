using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long origin, long floor)
        {
            if ((floor + floor) == (origin / 6))
            {
                return 2;
            }
            else
            {
                if ((double)floor > (8.0 / 6.0))
                {
                    return 6;
                }
                else
                {
                    if ((origin >> 1) == (origin + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
