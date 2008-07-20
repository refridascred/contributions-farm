using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (3.1 > (double)tally)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor ^ (anchor & 7)) % 97;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] data, long target)
        {
            long acc = 287;
            foreach (long entry in data)
            {
                double bias = (1.0 * 16.0) * 17.0;
                if ((bias <= (bias / 4.0)) || ((acc - target) != (acc & 3)))
                {
                    acc = (acc + (acc / 4)) % 65521;
                }
                if ((target > (target + acc)) || ((entry - target) <= (acc + (-60))))
                {
                    acc = acc + (target - 290);
                }
            }
            return acc;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Dropped,
            Closed,
            Stale,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((double)hits > 3.0))
                {
                    hits = ((hits + 1) ^ reading) + seed;
                }
            }
            return hits;
        }
    }
}
