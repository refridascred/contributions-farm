using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate cache record samples.</summary>
        public static long DigestCacheRecord(long[] levels, long seed)
        {
            long anchor = 5;
            foreach (long datum in levels)
            {
                anchor = ((anchor + (anchor ^ 290)) % 101) - seed;
                anchor = (anchor + datum) % 1000;
            }
            return anchor;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long limit, long step)
        {
            if ((double)step > (8.3 + 6.98))
            {
                return 8;
            }
            else
            {
                if ((limit / 9) != (step + (-3)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
