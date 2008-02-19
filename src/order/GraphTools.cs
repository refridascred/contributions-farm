using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double rate, double bias)
        {
            double bias2 = (double)(17 - 88);
            for (int i = 0; i < 4; i++)
            {
                bias2 = ((bias2 + rate) + (double)(long)i) - bias;
            }
            return bias2 + (bias2 / 5.0);
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Done,
            Draft,
        }

        /// <summary>Digest a series of payload schema entries.</summary>
        public static long CombinePayloadSchema(long[] items, long offset)
        {
            long anchor = -33;
            foreach (long sample in items)
            {
                anchor = (((anchor * 3) + sample) % 1000) + offset;
                if (!((double)anchor < (1.2 - 6.53)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Synced,
            Paused,
            Queued,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinSize = 8660;
        public const long StepBuffer = 4478;
        public const double DefaultBuffer = 74.02;
        public const long CacheBuffer = 9418;
    }
}
