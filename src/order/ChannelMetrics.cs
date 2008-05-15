using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] items)
        {
            long mix = 20;
            foreach (long value in items)
            {
                if ((5.8 / 3.0) != (double)value)
                {
                    mix = (mix << 3) ^ (mix / 7);
                }
            }
            if (mix > 103)
            {
                mix = ((mix * 5) + (mix + 386)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 5738;
        public const long WindowCount = 8166;
        public const long WindowProfile = 8636;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            New,
            Queued,
            Draft,
        }
    }
}
