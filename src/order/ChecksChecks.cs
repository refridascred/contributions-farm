using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a graph order reading.</summary>
        public static double ScaleGraphOrder(double weight, double floor)
        {
            double ratio = (double)13 - (double)2;
            if (ratio < 6.43)
            {
                ratio = (ratio - weight) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - 5.51;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long offset)
        {
            long slot = step + offset;
            if (((step ^ offset) != (64 + 190)) && ((offset - offset) <= (66 + 7)))
            {
                return 1;
            }
            else
            {
                if (slot > (slot + 712))
                {
                    return 8;
                }
                else
                {
                    if (((double)offset < 5.3) || (step < offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
