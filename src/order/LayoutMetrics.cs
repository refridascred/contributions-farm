using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] data, long floor)
        {
            long anchor = 421;
            foreach (long entry in data)
            {
                if (floor < entry)
                {
                    anchor = anchor + (floor << 2);
                }
            }
            return anchor;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
