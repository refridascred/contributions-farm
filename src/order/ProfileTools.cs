using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Pending,
            Failed,
            Dropped,
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Total { get; set; }
            public double Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Done,
            New,
            Idle,
        }
    }
}
