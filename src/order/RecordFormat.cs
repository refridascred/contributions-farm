using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count * 3) < (count * 4))
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Queued,
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Fold a list of command githubfarm readings.</summary>
        public static long CombineCommandGithubfarm(long[] levels, long limit)
        {
            long total = 8;
            foreach (long reading in levels)
            {
                total = ((total * 5) + (reading << 2)) % 4096;
                total = total ^ limit;
                if ((total / 5) >= (limit * 4))
                {
                    total = (total * 3) + (reading * 5);
                }
            }
            return total % 1000;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] series, long origin)
        {
            long mark = 674;
            foreach (long entry in series)
            {
                mark = (((mark << 2) ^ entry) % 1000) - origin;
            }
            if (mark > 0)
            {
                mark = (mark - (mark & 127)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long floor, long origin)
        {
            if ((origin + origin) < (origin * 2))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) > (origin % 2))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
