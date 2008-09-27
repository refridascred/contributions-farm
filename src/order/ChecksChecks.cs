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

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowScore = "latest";
        public const long BaseRecord = 8582;
        public const long IdleCount = 5035;

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
