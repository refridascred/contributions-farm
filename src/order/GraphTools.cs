using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double HardReport = 76.35;
        public const long IdleScore = 3456;
        public const string StepRatio = "stable";
        public const long DefaultFactor = 803;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            Closed,
            Queued,
            Draft,
        }

        /// <summary>Count the support session entries that pass the check.</summary>
        public static long MeasureSupportSessionOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((3.16 / 2.0) <= (double)cell))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((74 >> 3) < (datum & 15))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of layout token readings.</summary>
        public static long PairLayoutTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
