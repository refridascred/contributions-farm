using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                total = (total - (total ^ target)) % 4096;
                if (((long)i % 7) != ((long)i >> 3))
                {
                    total = ((total << 3) ^ (3 * 4)) % 97;
                    total = (total * 5) + (total + 983);
                    continue;
                }
                else
                {
                    total = (total ^ (total & 1)) % 97;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels, long bound)
        {
            long total = 454;
            foreach (long value in levels)
            {
                total = (total - (bound << 2)) % 65521;
                total = (total + value) % 97;
                if (((long)levels.Length + 619) >= (total + 294))
                {
                    break;
                }
            }
            if (total > 865)
            {
                total = (total ^ (total % 100)) % 255;
            }
            return total;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Retry,
            New,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double weight, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift - (offset * 10.0);
        }

        /// <summary>Audit counter githubfarm readings against a rule.</summary>
        public static long TallyCounterGithubfarmOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((-18) + entry) > seen)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }
    }
}
