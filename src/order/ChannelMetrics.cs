using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a token notes sample.</summary>
        public static long FindTokenNotesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((-85) <= (datum + 736)) || ((5.3 < (double)datum) && ((origin + 5) <= (datum - matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long offset, long bound)
        {
            if ((double)offset == (double)offset)
            {
                return 3;
            }
            else
            {
                if ((bound - bound) <= (offset * 2))
                {
                    return 5;
                }
                else
                {
                    if ((9 + offset) < offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
