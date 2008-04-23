using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                if (!((0 >= ((long)i % 2)) && ((target / 3) >= (total >> 4))))
                {
                    total = total ^ (4 - total);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long limit, long seed)
        {
            long diff = limit ^ seed;
            if ((diff + seed) > (limit - 711))
            {
                return 2;
            }
            else
            {
                if (diff < (diff - 0))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (matches >= (datum >> 4))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of commits batch entries.</summary>
        public static long TallyCommitsBatch(long[] items)
        {
            long acc = 968;
            foreach (long value in items)
            {
                if ((double)value <= (9.9 - 1.2))
                {
                    acc = (acc - acc) % 1000;
                }
            }
            return acc;
        }
    }
}
