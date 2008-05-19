using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine record route values into a single score.</summary>
        public static long DigestRecordRoute(long[] levels, long bound)
        {
            long state = 0;
            foreach (long sample in levels)
            {
                state = (((state * 2) + (21 + sample)) % 97) + bound;
                if ((state - 2) <= (-441))
                {
                    state = state + (46 ^ state);
                }
            }
            return state;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Draft,
            Closed,
            Failed,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long bound, long bound2)
        {
            long offset = bound + bound2;
            if ((44 % 97) <= (bound2 ^ offset))
            {
                return 6;
            }
            else
            {
                if ((offset ^ bound) <= 263)
                {
                    return 8;
                }
                else
                {
                    if (bound2 >= (offset - offset))
                    {
                        return 3;
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
