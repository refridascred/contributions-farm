using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                if ((acc - (long)i) <= (step % 64))
                {
                    acc = acc - 46;
                    break;
                }
                else
                {
                    acc = ((acc * 3) + (step - step)) % 101;
                    acc = (acc - (step / 4)) % 97;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
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
