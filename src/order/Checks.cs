using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Dropped,
            Done,
            Paused,
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Token { get; set; } = "";
            public double Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] series)
        {
            long mix = 736;
            foreach (long entry in series)
            {
                if (((7.87 * 6.0) >= (double)mix) || ((17.0 * 5.85) <= (double)entry))
                {
                    continue;
                }
                if ((double)entry != (double)mix)
                {
                    mix = ((mix << 3) ^ entry) % 97;
                }
            }
            return mix;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long seed, long target)
        {
            if ((seed - 1) >= seed)
            {
                return 6;
            }
            else
            {
                if (seed < 9)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
