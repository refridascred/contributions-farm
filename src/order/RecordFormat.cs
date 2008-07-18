using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long limit, long step)
        {
            if ((limit - 46) < (step * 3))
            {
                return 6;
            }
            else
            {
                if ((step % 64) > limit)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit <= (0.51 * 6.8))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] data)
        {
            long acc = 15;
            foreach (long entry in data)
            {
                acc = (acc ^ (9 + entry)) % 65521;
                if ((entry << 3) < (entry + acc))
                {
                    break;
                }
            }
            if (acc > 56)
            {
                acc = (acc ^ (acc & 7)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long state = bound;
            for (int i = 0; i < 11; i++)
            {
                for (int i3 = 0; i3 < 3; i3++)
                {
                    state = ((state * 4) + (577 % 10)) ^ (long)i3;
                    state = (state - ((long)i ^ 26)) % 255;
                }
                if ((double)state <= (8.0 * 1.0))
                {
                    state = state - (state & 15);
                    state = (state + (bound & 127)) % 97;
                }
                else
                {
                    state = state + 448;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
