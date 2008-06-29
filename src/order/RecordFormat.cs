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

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Locked,
            New,
            Ready,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] items)
        {
            long state = 8;
            foreach (long value in items)
            {
                if ((value + 448) == (value + state))
                {
                    state = (state ^ 219) % 1000;
                }
            }
            return state % 65521;
        }
    }
}
