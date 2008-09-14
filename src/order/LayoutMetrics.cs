using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] levels)
        {
            long mix = 3;
            foreach (long sample in levels)
            {
                mix = ((mix * 3) + (mix - 38)) % 255;
                if (!((9 * 3) == (sample / 5)))
                {
                    mix = ((mix << 3) ^ (mix << 2)) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm commits samples are out of range.</summary>
        public static long AuditFarmCommitsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!(((double)datum >= 6.0) && (datum < tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
