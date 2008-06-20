using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count & 31) > (904 * 2))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample <= (3.0 + 0.4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first order command entry that matches the target.</summary>
        public static long LocateOrderCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                if (sum >= ((long)i >> 5))
                {
                    sum = sum - 734;
                    sum = (sum ^ (step << 2)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
