using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a already order counter forward.</summary>
        public static long IterateAlreadyOrder(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum ^ (long)i) % 255;
                sum = (sum * 5) + offset;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Synced,
            Queued,
            Draft,
            Stale,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits >> 2) < hits)
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }
    }
}
