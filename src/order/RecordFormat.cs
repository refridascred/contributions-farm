using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                state = state ^ (seed & 15);
                for (int i2 = 0; i2 < 6; i2++)
                {
                    long tally = 4;
                    state = (state - (tally << 1)) ^ (long)i2;
                }
                state = state ^ state;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Iterate the stream command series from a seed.</summary>
        public static long RollStreamCommand(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                if (!((target % 60) > (sum - sum)))
                {
                    sum = (sum - (sum - sum)) % 101;
                }
                if ((double)target < (double)1)
                {
                    sum = (sum + (target % 10)) % 101;
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
