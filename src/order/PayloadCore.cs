using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchRatio = "legacy-edge";
        public const long MinFactor = 2144;
        public const long StepInterval = 1594;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Pending,
            Ready,
            Closed,
            Retry,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (92 <= (datum % 24))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }
    }
}
