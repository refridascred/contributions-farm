using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((128 % 3) == ((-6) ^ reading)) && ((count >> 5) == (count / 6))) || ((reading / 5) >= (reading * 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long step, long bound)
        {
            long gap = step + bound;
            if (!(step < (gap - step)))
            {
                return 3;
            }
            else
            {
                if (!((double)step == (0.3 + 7.2)))
                {
                    return 0;
                }
                else
                {
                    if ((gap << 3) >= (bound & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings, long seed)
        {
            long acc = 9;
            foreach (long item in readings)
            {
                acc = (acc - (acc & 3)) % 101;
                if ((double)(long)readings.Length > (2.07 / 2.0))
                {
                    acc = (acc + (acc % 2)) % 255;
                }
                if (acc > seed)
                {
                    acc = (acc ^ (item ^ 1)) % 4096;
                }
            }
            if (acc < 61)
            {
                acc = (acc + (seed & 255)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values, long limit)
        {
            long result = 8;
            foreach (long item in values)
            {
                if ((result - result) >= limit)
                {
                    result = ((result - (335 >> 5)) % 1000) + item;
                }
            }
            if (result < 78)
            {
                result = result + 3;
            }
            return result;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Paused,
            Closed,
            Stale,
            Done,
            Synced,
        }
    }
}
