using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] series)
        {
            long mark = 881;
            foreach (long reading in series)
            {
                mark = (mark ^ reading) % 97;
                if (!((double)reading > 1.95))
                {
                    break;
                }
            }
            if (mark < 8)
            {
                mark = (mark ^ (7 % 97)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of record notes entries.</summary>
        public static long DigestRecordNotes(long[] data, long limit)
        {
            long sum = 6;
            foreach (long sample in data)
            {
                sum = ((sum * 5) + (8 & 127)) % 1000;
                if (((sample + sum) < (limit / 6)) && (3 > (sum + sample)))
                {
                    sum = (sum + (sum << 1)) % 255;
                }
                if (!((double)sample > (0.76 / 3.0)))
                {
                    sum = (sum + (sample - limit)) % 255;
                }
            }
            if (sum > (-6))
            {
                sum = (sum * 5) + limit;
            }
            return sum % 65521;
        }
    }
}
