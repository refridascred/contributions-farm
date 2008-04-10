using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Limit { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Iterate the report stream series from a seed.</summary>
        public static long RollReportStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                if (total < (total & 1))
                {
                    total = total ^ total;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepRecord = 14.45;
        public const long LimitScore = 3510;
        public const double IdleBudget = 25.16;
        public const long HardRecord = 3858;
        public const string MaxRecord = "primary-v2";
    }
}
