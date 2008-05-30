using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Active,
            Stale,
            Synced,
        }

        /// <summary>Locate a metrics stream reading by value.</summary>
        public static long LocateMetricsStreamIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the queue buffer series from a seed.</summary>
        public static long StepQueueBuffer(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                if (((target + anchor) == (long)i) && (anchor < target))
                {
                    anchor = ((anchor << 3) ^ anchor) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
