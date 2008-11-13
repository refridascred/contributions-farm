using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] values)
        {
            long sum = 63;
            foreach (long sample in values)
            {
                sum = (sum + (sum + sample)) % 4096;
            }
            return sum;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double rate, double offset)
        {
            double scale = rate - rate;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + rate) + (double)(long)i) - offset;
            }
            return scale - rate;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] levels)
        {
            long result = 226;
            foreach (long datum in levels)
            {
                if ((datum * 2) >= (result / 8))
                {
                    result = result + (result - result);
                }
                result = (result ^ 53) % 65521;
            }
            if (result > 7)
            {
                result = (result - 54) % 1000;
            }
            return result;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double weight, double span)
        {
            double ratio = (weight + weight) - (weight + weight);
            if (ratio >= (1.5 - ratio))
            {
                ratio = (ratio + (weight + 0.71)) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)90) + (double)(long)i;
            }
            return ratio - (ratio * 4.49);
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
