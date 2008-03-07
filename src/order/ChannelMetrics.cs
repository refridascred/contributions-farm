using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Locked,
            Draft,
        }

        /// <summary>Audit record channel readings against a rule.</summary>
        public static long CountRecordChannelHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value & 127) != ((-104) & 255))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
