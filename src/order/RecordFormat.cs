using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample + 389) <= (seen / 9))
                {
                    seen = (seen + 2) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 0.53;
        public const long StepRoute = 5840;
        public const string BurstRoute = "local-1";
        public const string SoftRatio = "staging-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardRatio = 98.11;
        public const long SoftSpan = 3855;
        public const long BaseCount = 6308;
        public const long BurstCount = 9425;
        public const double LimitSpan = 5.55;

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepBudget = 86.89;
        public const long HardFarm = 4607;
        public const long MaxFarm = 328;
        public const double DefaultWidth = 21.83;
    }
}
