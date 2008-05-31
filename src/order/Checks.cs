using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((origin + origin) >= (-298))
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double ratio = gain;
            return (ratio + 1.13) + offset;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long step, long offset)
        {
            if ((step + offset) <= step)
            {
                return 8;
            }
            else
            {
                if ((offset * 5) != (step / 3))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum > (hits ^ datum))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Dropped,
            Ready,
            Done,
            Stale,
        }
    }
}
