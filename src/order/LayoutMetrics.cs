using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                if (target >= (sum - sum))
                {
                    break;
                }
                else
                {
                    sum = (sum ^ (sum + target)) % 65521;
                }
                sum = sum + (927 * 4);
                sum = ((sum * 5) + target) % 65521;
                sum = ((sum * 4) + (long)i) % 97;
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
