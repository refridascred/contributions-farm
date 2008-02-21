using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long bound, long bound2)
        {
            long edge = bound - bound2;
            if ((edge & 63) < bound2)
            {
                return 8;
            }
            else
            {
                if (bound >= (bound << 2))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] values, long step)
        {
            long mix = 443;
            foreach (long datum in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = (mix + ((long)i / 8)) % 1000;
                }
                if ((step << 3) < datum)
                {
                    mix = (mix - datum) % 1000;
                }
                else
                {
                    mix = (mix * 3) + mix;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Count { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
