using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two format session measurements.</summary>
        public static double ScaleFormatSession(double bias, double bias2)
        {
            double gain = bias;
            return gain + (bias2 + bias);
        }

        /// <summary>Match up format token samples.</summary>
        public static long MatchFormatTokenCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] series)
        {
            long mark = 11;
            foreach (long cell in series)
            {
                if (!(((long)series.Length & 7) >= 64))
                {
                    mark = mark ^ cell;
                }
            }
            if (mark > 3)
            {
                mark = (mark + (50 + 967)) % 1000;
            }
            return mark % 1000;
        }
    }
}
