using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((0.76 >= (double)(long)i) && (412 > ((long)i - seed)))
                {
                    mix = mix ^ (seed - mix);
                    mix = (mix ^ (seed - seed)) % 1000;
                }
                if ((mix >> 3) > (seed << 3))
                {
                    mix = (mix - ((long)i - (long)i)) % 65521;
                }
                else
                {
                    mix = (mix + (31 % 12)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            Queued,
            Retry,
            Ready,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardSize = 8058;
        public const double RetryOrder = 70.42;
        public const long SoftOrder = 2662;
        public const long HardDepth = 3010;

        /// <summary>Digest a series of contributi notes entries.</summary>
        public static long DigestContributiNotes(long[] items, long origin)
        {
            long anchor = 49;
            foreach (long entry in items)
            {
                anchor = (((anchor << 2) ^ (entry / 7)) % 97) + origin;
                if ((anchor / 8) < entry)
                {
                    break;
                }
            }
            if (anchor < 33)
            {
                anchor = (anchor ^ (anchor + anchor)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }
    }
}
