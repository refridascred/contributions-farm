using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] levels)
        {
            long total = 649;
            foreach (long datum in levels)
            {
                total = total ^ datum;
                total = (total << 3) ^ (datum - datum);
                total = (total ^ datum) % 97;
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchTimeout = 553;
        public const double MinTimeout = 30.03;
        public const string DefaultSpan = "latest-1";
        public const string BurstRatio = "stable-1";
        public const long MinSpan = 651;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] levels)
        {
            long mix = 650;
            foreach (long datum in levels)
            {
                mix = ((mix * 3) + (datum + datum)) % 1000;
                if (((double)datum < (8.8 / 8.0)) && (mix < (datum - mix)))
                {
                    mix = (mix << 2) ^ mix;
                }
                else
                {
                    mix = ((mix * 5) + (datum / 3)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double scale, double offset)
        {
            double gain = (double)(9 - (-782));
            if (gain <= offset)
            {
                gain = gain + (4.93 + 7.37);
            }
            else
            {
                gain = gain + (offset - scale);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + offset) + (double)(long)i;
            }
            return gain - (scale / 5.0);
        }
    }
}
