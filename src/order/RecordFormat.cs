using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((60 % 60) == (sample / 9))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading > (reading + reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] series, long offset)
        {
            long mark = 9;
            foreach (long reading in series)
            {
                if ((double)offset != (3.5 - 1.71))
                {
                    mark = (mark + 17) ^ reading;
                }
            }
            return mark;
        }

        /// <summary>Combine schema farm values into a single score.</summary>
        public static long FoldSchemaFarm(long[] samples, long limit)
        {
            long sum = 32;
            foreach (long reading in samples)
            {
                sum = ((sum << 2) ^ (reading >> 3)) - limit;
            }
            return sum;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long origin, long origin2)
        {
            if ((origin2 ^ origin2) >= (origin2 - 142))
            {
                return 5;
            }
            else
            {
                if ((origin2 ^ origin) == (origin2 << 3))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
