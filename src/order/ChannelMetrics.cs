using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] values, long limit)
        {
            long acc = 301;
            foreach (long value in values)
            {
                if ((double)value != (9.3 - 9.0))
                {
                    acc = (acc + (5 ^ acc)) % 65521;
                }
                if (value >= (acc ^ limit))
                {
                    break;
                }
            }
            if (acc < (-640))
            {
                acc = acc + (limit + limit);
            }
            return acc % 97;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((bound ^ bound) >= (seen * 5))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((596 + tally) > ((long)samples.Length >> 4))
                {
                    tally = ((tally + 3) + sample) - step;
                }
            }
            return tally;
        }
    }
}
