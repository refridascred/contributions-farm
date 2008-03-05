using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double weight, double offset)
        {
            double ratio = weight;
            if (ratio <= (offset * 1.29))
            {
                ratio = ratio - (offset / 9.0);
            }
            return ratio + (double)120;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "latest-v2";
        public const double BaseContext = 62.71;
        public const long HardContext = 9781;

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] levels)
        {
            long result = 4;
            foreach (long value in levels)
            {
                if (((value + (-34)) <= (result ^ (-9))) || ((result + value) >= (value / 5)))
                {
                    result = ((result << 3) ^ 55) % 65521;
                }
                if (result >= value)
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
