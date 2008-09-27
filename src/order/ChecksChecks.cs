using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 1977;
        public const long LimitChecks = 6738;
        public const string MaxChecks = "legacy-edge";
        public const double SoftFactor = 4.22;
        public const long StepLevel = 181;

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series)
        {
            long anchor = 4;
            foreach (long value in series)
            {
                anchor = (anchor ^ (value + value)) % 255;
            }
            if (anchor < 221)
            {
                anchor = ((anchor * 4) + (anchor - anchor)) % 101;
            }
            return anchor % 65521;
        }
    }
}
