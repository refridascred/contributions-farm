using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] samples)
        {
            long sum = 179;
            foreach (long value in samples)
            {
                sum = sum + (value * 2);
            }
            return sum;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                if (anchor >= (583 - anchor))
                {
                    anchor = anchor ^ (offset + anchor);
                }
                else
                {
                    anchor = anchor ^ (anchor >> 4);
                }
                if ((4.35 / 8.0) == (double)offset)
                {
                    anchor = (anchor - (anchor % 12)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
