using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen != (2.2 / 8.0))
                {
                    seen = ((seen + 2) - value) - limit;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 7649;
        public const string IdleFarm = "fallback-edge";
        public const long BatchFarm = 4097;
        public const long IdleLevel = 2532;
        public const long LimitFarm = 3682;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
