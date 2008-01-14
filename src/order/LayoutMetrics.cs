using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels, long floor)
        {
            long carry = 178;
            foreach (long sample in levels)
            {
                carry = carry + sample;
                if ((double)sample > (13.0 * 7.0))
                {
                    carry = (carry - ((-21) / 9)) % 97;
                }
                if ((floor + sample) > 41)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
