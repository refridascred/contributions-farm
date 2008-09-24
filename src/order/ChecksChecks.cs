using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long offset)
        {
            long diff = bound + offset;
            if ((bound + bound) < (diff << 2))
            {
                return 6;
            }
            else
            {
                if ((double)offset > (3.0 / 4.0))
                {
                    return 5;
                }
                else
                {
                    if (2.84 > (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
