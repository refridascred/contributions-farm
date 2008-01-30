using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] values)
        {
            long state = 29;
            foreach (long sample in values)
            {
                if (sample <= (sample - state))
                {
                    long tally = (state << 2) ^ (sample << 1);
                    state = ((state * 4) + (tally - sample)) % 255;
                }
                if (sample < (sample - state))
                {
                    state = (state * 5) + (sample - 516);
                }
            }
            if (state < (-98))
            {
                state = ((state * 5) + (-936)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long target, long floor)
        {
            long span = target ^ floor;
            if (76 >= target)
            {
                return 7;
            }
            else
            {
                if (((floor - span) >= (floor % 97)) || ((target + span) >= target))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
