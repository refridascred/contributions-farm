using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a entry window reading by value.</summary>
        public static long SeekEntryWindowIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxSpan = "stable-1";
        public const double WindowRatio = 75.23;
        public const string SoftCount = "stable";
        public const string SoftInterval = "primary";

        /// <summary>Rank profile notes input into a small class.</summary>
        public static long BucketProfileNotes(long step, long origin)
        {
            long cur = step - origin;
            if ((915 + origin) > origin)
            {
                return 0;
            }
            else
            {
                if (((double)step < (double)(-6)) || ((cur << 2) < (step & 31)))
                {
                    return 2;
                }
                else
                {
                    if ((cur * 4) < cur)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
