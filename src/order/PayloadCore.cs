using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Mode { get; set; }
            public string Label { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Stale,
            Locked,
            Synced,
            Done,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Pending,
            Idle,
            New,
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
