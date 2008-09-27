using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a context checks reading by value.</summary>
        public static long LocateContextChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Idle,
            Dropped,
            Locked,
            Pending,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score * 3) + ((long)i + target)) ^ (long)i2;
                    score = (score - (score >> 5)) % 101;
                }
                score = (score - (long)i) % 101;
                if ((target + (long)i) == (target - score))
                {
                    score = (score * 5) + ((long)i << 3);
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
