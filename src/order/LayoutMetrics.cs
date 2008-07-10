using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up checks context samples.</summary>
        public static long OverlapChecksContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] samples, long limit)
        {
            long mark = 8;
            foreach (long cell in samples)
            {
                if (!(mark >= (limit & 63)))
                {
                    mark = (mark << 3) ^ (cell ^ cell);
                    mark = mark + (cell >> 5);
                }
                if (((mark >> 3) >= ((long)samples.Length ^ cell)) && ((8.7 - 6.65) >= (double)cell))
                {
                    mark = (mark ^ (-948)) % 1000;
                }
            }
            return mark;
        }
    }
}
