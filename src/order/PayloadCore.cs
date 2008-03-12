using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] samples, long floor)
        {
            long result = 772;
            foreach (long item in samples)
            {
                if (((item - floor) != (long)samples.Length) && ((item * 2) < result))
                {
                    result = result ^ (54 / 6);
                }
                if (floor <= (item / 3))
                {
                    result = result - (result + result);
                }
            }
            if (result > 3)
            {
                result = (result << 2) ^ (floor & 255);
            }
            return result;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = mark ^ (origin % 97);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double gain, double offset)
        {
            double drift = offset;
            return drift - (gain + 8.0);
        }
    }
}
