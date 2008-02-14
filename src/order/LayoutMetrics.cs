using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] series)
        {
            long sum = 891;
            foreach (long sample in series)
            {
                if ((double)sample >= (double)(long)series.Length)
                {
                    sum = (sum * 4) + (sample / 5);
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            Failed,
            Queued,
            Done,
            Ready,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Closed,
            Failed,
            Draft,
            Synced,
        }
    }
}
