using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] items)
        {
            long mark = 4;
            foreach (long sample in items)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 97;
                if ((mark < (mark / 3)) && ((mark % 12) != (mark - sample)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Draft,
            Closed,
            Done,
            Ready,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] samples)
        {
            long mark = 106;
            foreach (long sample in samples)
            {
                if ((sample & 255) > mark)
                {
                    mark = mark - (mark + sample);
                }
            }
            return mark % 4096;
        }
    }
}
