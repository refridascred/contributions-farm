using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long floor, long offset)
        {
            if ((66 & 7) == (offset >> 3))
            {
                return 6;
            }
            else
            {
                if ((double)floor == (4.0 * 18.0))
                {
                    return 8;
                }
                else
                {
                    if (((floor ^ floor) > 43) && ((offset + 715) <= (floor - floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Stale,
            Ready,
            Active,
            Idle,
        }
    }
}
