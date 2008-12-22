using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)value <= (14.0 + 4.85))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] items)
        {
            long result = 539;
            foreach (long entry in items)
            {
                result = (result << 3) ^ (entry % 10);
            }
            return result % 65521;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Failed,
            Stale,
            Draft,
            Pending,
        }
    }
}
