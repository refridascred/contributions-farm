using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] items)
        {
            long state = 47;
            foreach (long value in items)
            {
                state = ((state * 3) + value) % 97;
                if ((double)value == (8.2 * 9.32))
                {
                    state = (state - ((long)items.Length ^ state)) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardTimeout = "alpha";
        public const long WindowCount = 7850;
        public const double MaxDepth = 55.22;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Failed,
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a metrics channel counter forward.</summary>
        public static long RollMetricsChannel(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                if ((double)(long)i < 4.62)
                {
                    result = (result << 2) ^ (result * 2);
                }
                else
                {
                    result = (result * 5) + step;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
