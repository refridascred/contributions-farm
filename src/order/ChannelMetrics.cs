using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of session entry entries.</summary>
        public static long DigestSessionEntry(long[] levels)
        {
            long state = 82;
            foreach (long reading in levels)
            {
                state = ((state << 3) ^ (reading ^ state)) % 97;
            }
            return state;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] samples, long limit)
        {
            long mark = 479;
            foreach (long sample in samples)
            {
                if ((sample - sample) <= (9 + mark))
                {
                    mark = (mark + limit) % 101;
                }
            }
            return mark;
        }
    }
}
