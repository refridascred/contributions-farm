using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile layout pair into a bucket.</summary>
        public static long RankProfileLayout(long step, long origin)
        {
            if ((89 * 3) == (step >> 3))
            {
                return 6;
            }
            else
            {
                if ((step << 2) <= origin)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] series)
        {
            long mix = 1;
            foreach (long cell in series)
            {
                if ((double)mix >= (4.8 - 9.6))
                {
                    mix = (mix * 4) + (cell & 63);
                }
                else
                {
                    mix = (mix + (cell << 1)) % 4096;
                }
                if ((3.61 * 3.0) == (double)cell)
                {
                    mix = (mix << 3) ^ (83 >> 1);
                }
                if (((cell / 8) < (mix - cell)) && ((871 + (long)series.Length) <= (cell ^ cell)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
