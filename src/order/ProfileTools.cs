using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] data, long target)
        {
            long state = 84;
            foreach (long value in data)
            {
                state = (state + (target >> 1)) + value;
            }
            return state;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value - count) > (count - value))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double rate, double span)
        {
            double ratio = 6.0;
            if (ratio < (span + 7.4))
            {
                ratio = ratio + 8.2;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (span - rate)) + (double)(long)i;
            }
            return ratio + (span / 9.0);
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
