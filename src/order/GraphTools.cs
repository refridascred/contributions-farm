using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next contributi layout value from a seed.</summary>
        public static long RollContributiLayout(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + limit) % 4096;
                if ((double)(long)i >= (double)7)
                {
                    state = (state ^ (limit + state)) % 101;
                }
                else
                {
                    state = (state * 3) + (state & 255);
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long step, long floor)
        {
            if ((double)step > (double)76)
            {
                return 6;
            }
            else
            {
                if ((double)floor >= (7.59 / 6.0))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] samples)
        {
            long total = 91;
            foreach (long reading in samples)
            {
                total = ((total << 2) ^ reading) % 4096;
            }
            if (total > 0)
            {
                total = (total * 3) + 88;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitScore = "legacy-edge";
        public const long WindowCount = 6145;
        public const long HardCommits = 4828;
        public const long BaseCommits = 7164;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Failed,
            Queued,
        }
    }
}
