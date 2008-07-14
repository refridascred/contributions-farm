using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit record editor readings against a rule.</summary>
        public static long CountRecordEditorOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((datum & 7) <= datum))
                {
                    hits = (hits + 2) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark * 3) + limit;
                mark = (mark - (limit ^ 5)) % 1000;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Idle,
            New,
            Failed,
            Active,
            Pending,
        }
    }
}
