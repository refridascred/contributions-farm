using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((((double)item == (3.89 / 5.0)) && (count < (item & 255))) && ((696 / 9) < count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double gain, double span)
        {
            double drift = 2.0;
            return (drift + (gain - drift)) + span;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)offset >= (double)hits)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long offset, long origin)
        {
            if ((origin + 71) <= origin)
            {
                return 5;
            }
            else
            {
                if ((double)origin != (4.0 + 12.0))
                {
                    return 3;
                }
                else
                {
                    if (!((origin << 3) >= origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset > (origin << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }
    }
}
