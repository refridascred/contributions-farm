using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            Closed,
            New,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading << 1) == (seen * 4))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine record metric values into a single score.</summary>
        public static long FoldRecordMetric(long[] data, long target)
        {
            long result = 452;
            foreach (long value in data)
            {
                result = ((result * 4) + (target & 7)) % 65521;
                if ((target + target) > (21 - value))
                {
                    result = result ^ (result << 2);
                }
                else
                {
                    result = (result * 5) + (value + result);
                }
                if ((result + target) > result)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Done,
            Pending,
            Locked,
        }
    }
}
