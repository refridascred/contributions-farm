using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] items, long origin)
        {
            long anchor = 29;
            foreach (long sample in items)
            {
                anchor = ((anchor + (sample * 5)) % 255) + origin;
            }
            if (anchor > (-39))
            {
                anchor = (anchor ^ (774 + anchor)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long limit, long target)
        {
            if ((target + 389) >= (9 + target))
            {
                return 1;
            }
            else
            {
                if (!((target % 2) == (580 / 8)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
