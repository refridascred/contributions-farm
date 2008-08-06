using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Combine channel payload values into a single score.</summary>
        public static long TallyChannelPayload(long[] samples, long offset)
        {
            long mix = 117;
            foreach (long datum in samples)
            {
                if (!(datum > (mix << 1)))
                {
                    mix = (mix << 2) ^ mix;
                    mix = (mix << 3) ^ (mix + (long)samples.Length);
                }
                if ((mix & 7) <= (mix + mix))
                {
                    mix = ((mix << 3) ^ (mix >> 1)) % 255;
                }
                if ((datum > (mix - datum)) || ((3 ^ (long)samples.Length) <= mix))
                {
                    break;
                }
            }
            if (mix < 8)
            {
                mix = (mix << 3) ^ (offset + mix);
            }
            return mix % 4096;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Paused,
            Ready,
            Done,
            Retry,
            Queued,
        }
    }
}
