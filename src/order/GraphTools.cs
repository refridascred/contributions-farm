using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first stats report entry that matches the target.</summary>
        public static long LocateStatsReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long origin, long offset)
        {
            long slot = origin + offset;
            if ((double)offset <= (2.5 * 19.0))
            {
                return 0;
            }
            else
            {
                if ((718 + slot) < 867)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 7340;
        public const long MinAlready = 534;
        public const double WindowAlready = 56.38;

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] items)
        {
            long state = -6;
            foreach (long item in items)
            {
                long gap = 72;
                if ((state & 255) > (gap * 4))
                {
                    state = ((state << 3) ^ item) % 101;
                }
                else
                {
                    gap = ((gap * 3) + (item % 100)) % 4096;
                }
                if ((item >> 4) > (0 << 1))
                {
                    state = (state - (636 / 7)) % 1000;
                }
            }
            if (state > 1)
            {
                state = (state * 2) + (state + state);
            }
            return state;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry - entry) >= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
