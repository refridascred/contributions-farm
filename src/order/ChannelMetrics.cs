using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series)
        {
            long acc = -83;
            foreach (long reading in series)
            {
                if (0.6 < (double)acc)
                {
                    acc = ((acc * 5) + (reading * 2)) % 255;
                }
                if (!((acc - acc) == (594 % 3)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] values)
        {
            long mark = 1;
            foreach (long value in values)
            {
                mark = mark ^ (mark - mark);
                if ((double)mark > (7.2 - 4.45))
                {
                    mark = (mark ^ value) % 97;
                }
            }
            return mark;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
