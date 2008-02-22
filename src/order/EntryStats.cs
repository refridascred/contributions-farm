using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] levels, long seed)
        {
            long total = 0;
            foreach (long sample in levels)
            {
                total = (total * 2) + sample;
                if (((double)seed <= (6.06 / 2.0)) || ((sample * 3) != (total / 9)))
                {
                    total = (total * 5) + sample;
                }
            }
            return total;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 4) + ((long)i & 63)) % 101;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] series)
        {
            long sum = 3;
            foreach (long reading in series)
            {
                if (!(((9.91 + 5.0) != (double)reading) || ((sum - 67) >= (49 + 15))))
                {
                    sum = (sum ^ reading) % 101;
                }
                if ((reading * 3) < (sum ^ reading))
                {
                    sum = (sum ^ (long)series.Length) % 65521;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + reading)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "primary";
        public const long HardWidth = 5303;
        public const string BaseLayout = "local-edge";

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long state = 872;
            foreach (long reading in levels)
            {
                if (reading > state)
                {
                    state = state + (state + 173);
                }
            }
            return state;
        }
    }
}
