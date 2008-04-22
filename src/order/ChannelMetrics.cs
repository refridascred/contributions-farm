using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix - (98 + mix)) % 255;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((floor / 8) < floor)
                {
                    break;
                }
                else
                {
                    mix = (mix * 3) + (floor + floor);
                    mix = mix ^ (floor % 7);
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "cached-v2";
        public const long MaxNotes = 3934;
        public const long DefaultNotes = 2680;
        public const string RetryInterval = "fallback";
        public const long BaseNotes = 6319;
    }
}
