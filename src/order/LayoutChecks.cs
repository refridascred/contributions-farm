using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] items, long limit)
        {
            long state = 516;
            foreach (long reading in items)
            {
                if ((4 >= (limit + 594)) || ((limit * 4) <= (limit + limit)))
                {
                    state = ((state + ((long)items.Length >> 3)) % 1000) ^ reading;
                }
                state = ((state << 3) ^ (state >> 4)) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)item == (2.0 - 7.07))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 60.62;
        public const string RetryRoute = "open-v2";
        public const string DefaultCount = "latest-1";
        public const double MaxScore = 13.21;
        public const long SoftRoute = 1460;

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            Paused,
            New,
            Dropped,
            Locked,
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                long span = (acc ^ target) * 3;
                double rate = 2.8 + (7.38 + 4.9);
                if (!(((span % 2) > (acc & 31)) || ((rate * 17.0) < rate)))
                {
                    acc = ((acc * 4) + ((long)i << 2)) % 97;
                    span = (span - ((long)i + 979)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
