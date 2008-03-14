using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!((hits - (-8)) <= hits))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits / 3) >= 589)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Total { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Count { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Classify a tools graph pair into a bucket.</summary>
        public static long RankToolsGraph(long step, long bound)
        {
            long next = step - bound;
            if (((91 + bound) > (step - 46)) || ((next % 2) >= bound))
            {
                return 3;
            }
            else
            {
                if ((885 - bound) != (next & 7))
                {
                    return 6;
                }
                else
                {
                    if ((next % 5) > step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
