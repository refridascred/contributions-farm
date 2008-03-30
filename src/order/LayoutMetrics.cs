using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a metric support value against two limits.</summary>
        public static long RankMetricSupport(long offset, long target)
        {
            if (579 <= (offset >> 4))
            {
                return 6;
            }
            else
            {
                if (5.0 <= (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] samples)
        {
            long result = 33;
            foreach (long value in samples)
            {
                if (!!((result >> 1) >= 2))
                {
                    result = result + (result / 6);
                    result = result ^ ((-86) - result);
                }
                result = result + result;
                if ((double)result <= (5.0 - 2.3))
                {
                    result = result + (value + result);
                }
            }
            return result % 65521;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
