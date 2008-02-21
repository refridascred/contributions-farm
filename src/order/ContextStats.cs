using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((-3) & 127) < (state >> 5))
                {
                    state = ((state << 2) ^ (bound << 2)) % 101;
                    state = state ^ (bound >> 1);
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
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
