using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every command order entry stays within the limit.</summary>
        public static bool ValidateCommandOrderBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
