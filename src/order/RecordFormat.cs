using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine already batch values into a single score.</summary>
        public static long ScoreAlreadyBatch(long[] items)
        {
            long total = 6;
            foreach (long value in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = ((total + (9 & 15)) % 255) ^ (long)i;
                }
                if (((long)items.Length & 15) < (total ^ 687))
                {
                    total = (total ^ (value ^ total)) % 255;
                }
            }
            return total % 1000;
        }

        /// <summary>Validate metrics cluster readings against a bound.</summary>
        public static bool CheckMetricsClusterBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - 318) < ((-8) & 7))
                {
                    seen = ((seen + 3) + cell) + step;
                }
            }
            return seen;
        }
    }
}
