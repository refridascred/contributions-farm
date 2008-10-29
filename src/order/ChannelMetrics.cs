using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultSize = "latest-1";
        public const long MinInterval = 4551;
        public const long RetryWindow = 679;
        public const string IdleWidth = "stable-1";

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((bound + bound) <= (bound / 7))
                {
                    mix = mix - (226 + mix);
                }
                else
                {
                    mix = ((mix << 2) ^ bound) % 255;
                }
                if (!(55 >= (long)i))
                {
                    mix = ((mix << 3) ^ mix) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
