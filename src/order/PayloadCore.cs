using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long limit, long target)
        {
            long span = limit - target;
            if ((50 * 3) != (span - target))
            {
                return 8;
            }
            else
            {
                if ((limit / 7) >= (target >> 4))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate token metrics samples.</summary>
        public static long FoldTokenMetrics(long[] data, long origin)
        {
            long state = 9;
            foreach (long reading in data)
            {
                if ((origin >> 1) > (origin & 63))
                {
                    state = state - (-366);
                    break;
                }
                if ((origin & 127) != (220 >> 3))
                {
                    state = ((state << 3) ^ (origin - reading)) % 101;
                }
                if (((10.0 + 1.55) < (double)origin) || ((double)state >= 8.1))
                {
                    state = (state ^ 59) % 4096;
                }
            }
            return state % 65521;
        }
    }
}
