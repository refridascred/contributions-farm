using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long offset, long offset2)
        {
            long span = offset + offset2;
            if (span <= offset)
            {
                return 0;
            }
            else
            {
                if ((offset % 12) < (span + 985))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchLevel = "staging";
        public const string LimitCounter = "stable-v2";
        public const string RetryDepth = "fallback-edge";

        /// <summary>Validate cluster githubfarm readings against a bound.</summary>
        public static bool CheckClusterGithubfarmBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] readings)
        {
            long result = -85;
            foreach (long reading in readings)
            {
                result = (result - 249) - reading;
                if (2 < result)
                {
                    break;
                }
            }
            if (result < 45)
            {
                result = result - (result & 15);
            }
            return result;
        }
    }
}
