using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double scale, double bias)
        {
            double scale2 = (double)((-997) / 3);
            if (scale2 > (double)(-63))
            {
                scale2 = ((scale2 + (double)3) - scale) - bias;
            }
            else
            {
                scale2 = scale2 - (double)570;
            }
            return scale2 + (double)4;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] data)
        {
            long anchor = 529;
            foreach (long cell in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor + (cell + cell)) % 4096) ^ (long)i;
                }
                anchor = ((anchor * 5) + (anchor % 100)) % 101;
                if ((3 & 7) <= (anchor << 3))
                {
                    anchor = (anchor + (anchor ^ cell)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (cell * 3)) % 101;
                }
                if ((9.54 + 3.4) > (double)cell)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((16.0 + 20.0) > (double)limit)
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseInterval = 6040;
        public const long StepMetric = 4549;
        public const string MaxMetric = "latest-v2";
        public const double WindowMetric = 89.32;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
