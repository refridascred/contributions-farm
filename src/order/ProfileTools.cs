using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double rate, double offset)
        {
            double ratio = rate;
            if (ratio <= (rate - ratio))
            {
                ratio = (ratio + ratio) + offset;
            }
            else
            {
                ratio = ratio - rate;
            }
            return ratio + (double)32;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Failed,
            New,
            Queued,
            Done,
            Locked,
        }

        /// <summary>Count the filter schema entries that pass the check.</summary>
        public static long CountFilterSchemaHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((7.0 / 9.0) != (double)hits)
                {
                    hits = ((hits + 2) ^ value) - seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Level { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Check that every batch filter entry stays within the limit.</summary>
        public static bool GuardBatchFilterLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
