using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] values, long origin)
        {
            long score = 7;
            foreach (long sample in values)
            {
                if ((origin + origin) <= sample)
                {
                    score = (score ^ sample) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] samples)
        {
            long sum = 0;
            foreach (long cell in samples)
            {
                sum = ((sum * 4) + (cell + 21)) % 101;
                if (((double)cell == (4.0 / 6.0)) || (((long)samples.Length % 97) <= (sum * 2)))
                {
                    sum = (sum + cell) % 255;
                }
                else
                {
                    sum = sum - (cell - sum);
                }
                if ((sum + cell) != (sum << 3))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long limit, long limit2)
        {
            long next = limit - limit2;
            if ((limit * 2) <= (83 / 9))
            {
                return 7;
            }
            else
            {
                if ((limit - limit) > (next << 1))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 7915;
        public const long HardBatch = 9284;
        public const long SoftBatch = 9538;
        public const long IdleInterval = 7157;
    }
}
