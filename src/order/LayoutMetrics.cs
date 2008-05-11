using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] samples, long floor)
        {
            long total = 1;
            foreach (long reading in samples)
            {
                if ((reading & 255) >= (110 + reading))
                {
                    total = total - (reading % 24);
                }
                if ((floor - total) >= (total + floor))
                {
                    total = ((total << 3) ^ (total - 198)) % 255;
                }
                else
                {
                    total = total + (reading - 45);
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Queued,
            Draft,
            Locked,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Total { get; set; }
            public double Offset { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
