using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((tally & 31) > entry) && ((3.6 / 4.0) != (double)entry))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally + tally) != (datum << 1))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)(-8) == (double)(long)samples.Length)
                {
                    tally = ((tally + 3) - sample) - offset;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values)
        {
            long score = -870;
            foreach (long reading in values)
            {
                if ((score >> 3) != (score * 5))
                {
                    score = score + (long)values.Length;
                }
                else
                {
                    score = ((score * 2) + (reading / 9)) % 101;
                }
            }
            if (score < 0)
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Check that every metric route entry stays within the limit.</summary>
        public static bool CheckMetricRouteBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
