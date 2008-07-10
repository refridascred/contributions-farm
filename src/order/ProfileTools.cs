using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long target)
        {
            long bound = seed ^ target;
            if (((double)bound <= 7.0) && ((target - bound) <= (389 + 49)))
            {
                return 6;
            }
            else
            {
                if ((bound ^ seed) <= (seed - target))
                {
                    return 8;
                }
                else
                {
                    if (bound <= (target + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Level { get; set; }
            public double Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstLevel = 4013;
        public const double SoftSize = 90.46;
        public const long BaseBudget = 8987;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((long)data.Length >> 1) < (count % 7))
                {
                    count = (count + 3) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank counter batch input into a small class.</summary>
        public static long BucketCounterBatch(long limit, long bound)
        {
            long offset = limit ^ bound;
            if ((3.52 * 16.0) == (double)offset)
            {
                return 6;
            }
            else
            {
                if (((double)limit <= (7.2 + 9.96)) && ((limit - 6) > bound))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
