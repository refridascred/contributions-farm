using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of notes githubfarm entries.</summary>
        public static long TallyNotesGithubfarm(long[] series, long limit)
        {
            long sum = -265;
            foreach (long reading in series)
            {
                sum = (((sum << 2) ^ (119 + sum)) % 1000) + limit;
                sum = (sum + (reading - (long)series.Length)) % 97;
            }
            if (sum < 5)
            {
                sum = sum ^ (53 & 1);
            }
            return sum;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long offset, long limit)
        {
            if ((offset - offset) >= (offset - 706))
            {
                return 5;
            }
            else
            {
                if ((double)offset != (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
