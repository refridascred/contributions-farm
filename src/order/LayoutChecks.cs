using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string WindowScore = "open-v2";
        public const long WindowCommand = 4393;
        public const string StepInterval = "legacy-1";
        public const long LimitCommand = 5785;
        public const long RetryCommand = 7870;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Retry,
            Synced,
            Paused,
            Pending,
            Locked,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum - (sum - limit)) % 65521;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    long bound = (long)i;
                    sum = (((sum << 3) ^ (limit - bound)) % 1000) - (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Validate window buffer readings against a bound.</summary>
        public static bool ValidateWindowBufferRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double bias)
        {
            double rate = 1.1;
            if (rate >= ratio)
            {
                rate = (rate + ratio) + bias;
            }
            return rate + (double)9;
        }
    }
}
