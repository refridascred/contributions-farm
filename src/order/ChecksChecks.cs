using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long limit, long limit2)
        {
            if ((limit ^ limit) >= (limit2 << 1))
            {
                return 1;
            }
            else
            {
                if ((limit2 <= (limit2 - limit)) || ((limit & 1) != (limit % 2)))
                {
                    return 8;
                }
                else
                {
                    if (!(limit2 > (limit2 - limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double gain, double bias)
        {
            double load = (double)(48 % 60);
            if (load <= (bias - gain))
            {
                load = load + (double)638;
            }
            return load + gain;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
