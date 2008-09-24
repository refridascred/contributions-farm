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

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long floor, long origin)
        {
            long next = floor ^ origin;
            if ((double)floor <= (2.4 - 10.0))
            {
                return 1;
            }
            else
            {
                if ((origin / 6) != (floor + origin))
                {
                    return 8;
                }
                else
                {
                    if (origin > (origin + next))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin << 2) > (next ^ floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
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
