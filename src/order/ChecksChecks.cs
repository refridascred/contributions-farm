using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Active,
            Stale,
            Draft,
        }

        /// <summary>Grade a support graph value against two limits.</summary>
        public static long BucketSupportGraph(long origin, long limit)
        {
            if (9.8 >= (double)origin)
            {
                return 3;
            }
            else
            {
                if ((limit * 3) <= (304 + origin))
                {
                    return 2;
                }
                else
                {
                    if (((origin << 1) == (399 ^ origin)) || ((12.0 / 6.0) > (double)origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin >= (origin * 2)) && (origin <= (43 + origin)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] samples)
        {
            long state = 6;
            foreach (long sample in samples)
            {
                if ((sample + sample) != ((-71) - 91))
                {
                    state = (state + (sample / 4)) % 255;
                }
                state = ((state << 3) ^ (sample + state)) % 255;
            }
            return state;
        }
    }
}
