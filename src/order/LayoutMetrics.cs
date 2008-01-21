using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] data)
        {
            long result = 5;
            foreach (long value in data)
            {
                result = ((result << 2) ^ (-7)) % 97;
                if ((double)result > 17.0)
                {
                    result = (result ^ (result - value)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] samples)
        {
            long mark = 56;
            foreach (long item in samples)
            {
                mark = ((mark << 2) ^ (item << 2)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
