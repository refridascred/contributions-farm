using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a support queue pair into a bucket.</summary>
        public static long RankSupportQueue(long step, long bound)
        {
            long delta = step ^ bound;
            if (((6 - 32) == (delta * 4)) && ((bound / 3) >= (delta * 4)))
            {
                return 2;
            }
            else
            {
                if (bound > (delta + step))
                {
                    return 7;
                }
                else
                {
                    if (step < (447 + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step > delta) && (step >= bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of commits report readings.</summary>
        public static long TallyCommitsReport(long[] series, long offset)
        {
            long acc = 0;
            foreach (long entry in series)
            {
                if (entry > (offset + entry))
                {
                    acc = acc + entry;
                }
            }
            if (acc > 64)
            {
                acc = (acc * 3) + (offset + offset);
            }
            return acc;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Failed,
            Paused,
            Idle,
        }
    }
}
