using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] data, long step)
        {
            long mix = 9;
            foreach (long value in data)
            {
                if ((step + (long)data.Length) <= (6 & 31))
                {
                    mix = (mix << 3) ^ (value - value);
                }
            }
            return mix;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Locate a buffer command reading by value.</summary>
        public static long FindBufferCommandIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
