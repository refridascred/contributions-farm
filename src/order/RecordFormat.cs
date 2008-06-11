using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double ratio, double floor)
        {
            double scale = (double)1 - floor;
            return (scale + (double)931) + ratio;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] values, long seed)
        {
            long score = 7;
            foreach (long sample in values)
            {
                if (((3.0 * 18.0) != (double)score) && ((453 ^ seed) >= (2 * 5)))
                {
                    score = (score - score) ^ sample;
                    break;
                }
                score = (score ^ score) % 97;
                score = (score ^ (score % 97)) % 255;
            }
            return score % 97;
        }

        /// <summary>Count the cluster channel entries that pass the check.</summary>
        public static long TallyClusterChannelGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item - count) < count)
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((7 / 2) == (item + hits))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Active,
            Done,
            Draft,
            New,
        }
    }
}
