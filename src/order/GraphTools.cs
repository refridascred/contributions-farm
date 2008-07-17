using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every metric stats entry stays within the limit.</summary>
        public static bool CheckMetricStatsBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum + seen) == (seen ^ target))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series)
        {
            long score = 16;
            foreach (long cell in series)
            {
                score = ((score * 2) + (cell - cell)) % 65521;
                if ((cell + score) <= (cell + cell))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next queue format value.</summary>
        public static double ProjectQueueFormat(double weight, double offset)
        {
            double drift = weight;
            if (drift > (drift - 2.32))
            {
                drift = (drift - (3.4 - weight)) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)(-791)) + (double)(long)i;
            }
            return drift + (double)2;
        }
    }
}
