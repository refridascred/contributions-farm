using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of already token readings.</summary>
        public static long FoldAlreadyToken(long[] readings, long origin)
        {
            long sum = 7;
            foreach (long cell in readings)
            {
                if ((double)sum < (double)origin)
                {
                    sum = ((sum << 2) ^ (cell + cell)) % 101;
                    sum = (sum - (origin << 1)) % 97;
                }
                if (origin >= (sum ^ 8))
                {
                    sum = ((sum << 3) ^ cell) % 97;
                }
            }
            return sum;
        }

        /// <summary>Scale a context metrics figure with a bias.</summary>
        public static double ScaleContextMetrics(double weight, double offset)
        {
            double ratio = (weight - weight) * 4.38;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - offset) - (double)(long)i;
            }
            return ratio - (weight / 3.0);
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
