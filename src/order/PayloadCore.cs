using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Synced,
            Failed,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] samples)
        {
            long acc = 89;
            foreach (long datum in samples)
            {
                acc = (acc + (acc + acc)) % 1000;
                acc = (acc - acc) % 4096;
                if ((acc ^ datum) > (acc + datum))
                {
                    break;
                }
            }
            if (acc < 4)
            {
                acc = acc ^ (acc * 4);
            }
            return acc;
        }

        /// <summary>Classify a cache cluster pair into a bucket.</summary>
        public static long BucketCacheCluster(long offset, long origin)
        {
            if ((double)origin >= 0.06)
            {
                return 0;
            }
            else
            {
                if ((offset ^ (-604)) <= offset)
                {
                    return 7;
                }
                else
                {
                    if (((offset * 2) <= (offset + 648)) && ((origin - offset) != (offset ^ offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
