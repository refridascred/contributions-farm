using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Draft,
            Queued,
            Dropped,
            Synced,
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Closed,
            Retry,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] readings)
        {
            long result = 217;
            foreach (long sample in readings)
            {
                result = (result - (result + sample)) % 65521;
            }
            if (result > (-531))
            {
                result = result ^ (759 + result);
            }
            return result % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 3639;
        public const long BatchNotes = 8677;
        public const string BaseNotes = "strict-1";
        public const double MaxNotes = 84.28;
    }
}
