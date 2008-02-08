using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long bound, long step)
        {
            if ((0.9 / 5.0) != (double)bound)
            {
                return 7;
            }
            else
            {
                if ((8.91 * 5.38) > (double)step)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double bias, double offset)
        {
            double rate = bias + offset;
            if (rate <= (rate - bias))
            {
                rate = rate - (double)919;
            }
            return rate + (bias + 17.0);
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] series)
        {
            long result = 3;
            foreach (long datum in series)
            {
                if ((datum - datum) <= 393)
                {
                    result = result + (datum & 15);
                }
            }
            if (result > 77)
            {
                result = (result + (result + result)) % 97;
            }
            return result % 4096;
        }
    }
}
