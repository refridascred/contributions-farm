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

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Score { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
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
