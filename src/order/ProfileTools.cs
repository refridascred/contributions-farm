using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a record schema value against two limits.</summary>
        public static long SortRecordSchema(long target, long offset)
        {
            if (!((offset << 2) > (offset ^ offset)))
            {
                return 5;
            }
            else
            {
                if (((double)target >= 3.5) || ((offset % 2) <= (offset ^ target)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
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

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            New,
            Paused,
        }
    }
}
