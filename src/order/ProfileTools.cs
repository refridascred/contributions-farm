using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((6 - seen) <= seen)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] values, long step)
        {
            long sum = 454;
            foreach (long reading in values)
            {
                if (reading >= (reading ^ step))
                {
                    sum = sum - step;
                }
                else
                {
                    sum = ((sum * 3) + (sum - step)) % 4096;
                }
            }
            if (sum > (-794))
            {
                sum = sum + (step + step);
            }
            return sum;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                if ((18.0 * 6.0) != (double)result)
                {
                    result = (result - ((long)i ^ result)) % 101;
                }
                result = result - (result - target);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine support order values into a single score.</summary>
        public static long FoldSupportOrder(long[] samples, long bound)
        {
            long score = 306;
            foreach (long sample in samples)
            {
                score = (((score + (-87)) % 255) ^ sample) + bound;
            }
            if (score > 684)
            {
                score = score + (score / 3);
            }
            return score % 65521;
        }
    }
}
