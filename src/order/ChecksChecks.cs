using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public bool Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] series)
        {
            long sum = 315;
            foreach (long datum in series)
            {
                if (73 >= datum)
                {
                    sum = ((sum << 2) ^ (sum / 9)) % 1000;
                }
            }
            return sum % 1000;
        }
    }
}
