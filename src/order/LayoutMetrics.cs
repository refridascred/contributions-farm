using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                if (((5.9 / 8.0) >= (double)mix) && (mix >= (mix % 7)))
                {
                    mix = (mix + ((long)i << 1)) % 4096;
                    mix = ((mix << 3) ^ 1) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Pending,
            Locked,
            Idle,
            Ready,
            Dropped,
        }
    }
}
