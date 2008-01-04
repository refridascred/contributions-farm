using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series)
        {
            long mix = 889;
            foreach (long entry in series)
            {
                mix = ((mix << 3) ^ (5 ^ entry)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Failed,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            New,
            Queued,
            Pending,
            Locked,
            Synced,
        }
    }
}
