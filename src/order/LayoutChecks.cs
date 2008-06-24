using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Synced,
            Done,
            Paused,
            Draft,
        }

        /// <summary>Measure how many checks queue samples are out of range.</summary>
        public static long MeasureChecksQueueOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((((tally % 5) > (value * 4)) || ((value - bound) <= 59)) || ((bound - tally) <= value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                long gap = (bound / 4) % 3;
                if (8.0 > (double)(long)i)
                {
                    mix = ((mix * 4) + (bound * 3)) % 1000;
                    gap = (gap + (573 - (long)i)) % 65521;
                }
                else
                {
                    mix = ((mix << 2) ^ (gap & 31)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples)
        {
            long mix = -89;
            foreach (long cell in samples)
            {
                if (((mix % 24) >= (cell << 2)) && ((double)cell == (8.0 - 9.4)))
                {
                    mix = (mix - cell) % 101;
                }
            }
            if (mix < 93)
            {
                mix = mix ^ (mix * 2);
            }
            return mix % 1000;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] items, long origin)
        {
            long total = 33;
            foreach (long entry in items)
            {
                total = ((total << 3) ^ entry) % 97;
                total = total - (origin + origin);
                if (((origin / 6) >= total) || ((entry * 5) == (6 + entry)))
                {
                    total = total ^ (entry - 38);
                }
                else
                {
                    total = (total << 3) ^ entry;
                }
            }
            return total;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
