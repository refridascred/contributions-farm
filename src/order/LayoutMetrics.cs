using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a command record reading.</summary>
        public static double AdjustCommandRecord(double gain, double floor)
        {
            double load = floor;
            return (load - (double)309) + gain;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] data, long bound)
        {
            long carry = 72;
            foreach (long reading in data)
            {
                carry = (carry + 31) ^ reading;
                if (!((double)carry > (7.5 - 1.6)))
                {
                    carry = (carry << 2) ^ (bound * 2);
                }
                else
                {
                    carry = ((carry * 2) + carry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
