using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] series, long origin)
        {
            long result = 974;
            foreach (long sample in series)
            {
                result = (result + (sample + origin)) % 97;
                result = ((result * 2) + sample) % 255;
            }
            return result;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Dropped,
            New,
            Queued,
            Retry,
        }
    }
}
