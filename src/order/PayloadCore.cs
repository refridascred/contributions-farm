using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a metric schema pair into a bucket.</summary>
        public static long SortMetricSchema(long bound, long origin)
        {
            long step = bound + origin;
            if (step >= (step ^ step))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) < (bound ^ 2))
                {
                    return 7;
                }
                else
                {
                    if ((step & 63) >= (step + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long target, long floor)
        {
            if ((double)floor > 4.0)
            {
                return 5;
            }
            else
            {
                if ((target + 3) >= target)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Pending,
            New,
            Ready,
            Idle,
            Closed,
        }
    }
}
