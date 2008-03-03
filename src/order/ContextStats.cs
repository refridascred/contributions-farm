using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count >> 3) > count)
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate queue context samples.</summary>
        public static long ScoreQueueContext(long[] values, long step)
        {
            long result = 47;
            foreach (long entry in values)
            {
                if (((result + 841) <= (step ^ entry)) && (547 >= (entry - 7)))
                {
                    result = (result * 4) + entry;
                }
            }
            if (result > (-8))
            {
                result = result - step;
            }
            return result % 65521;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
