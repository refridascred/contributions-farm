using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next account notes value.</summary>
        public static double AdjustAccountNotes(double ratio, double offset)
        {
            double mean = (ratio * 13.0) * 2.19;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (offset / 2.0)) - (double)(long)i;
            }
            return mean + (double)(-527);
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((mix ^ bound) <= (bound + 69))
                {
                    mix = ((mix * 5) + mix) % 255;
                }
                for (int i3 = 0; i3 < 10; i3++)
                {
                    mix = ((mix + ((-361) + mix)) % 4096) ^ (long)i3;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Done,
            Paused,
            New,
            Closed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardLevel = "local-edge";
        public const double BurstTools = 45.28;
        public const long CacheCount = 4459;
        public const long DefaultTools = 9818;
        public const long LimitTools = 1047;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Ready,
            Idle,
            Failed,
            Retry,
        }
    }
}
