using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Owner { get; set; }
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading > (5.93 * 2.9))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
