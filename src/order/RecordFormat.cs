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

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double ratio, double floor)
        {
            double load = ratio;
            return (load - 19.0) + floor;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Retry,
            New,
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
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
