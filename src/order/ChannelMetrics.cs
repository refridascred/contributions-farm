using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Retry,
            Paused,
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor schema value against two limits.</summary>
        public static long ClassifyEditorSchema(long limit, long origin)
        {
            if ((limit + limit) != (limit ^ limit))
            {
                return 0;
            }
            else
            {
                if (77 >= (limit - origin))
                {
                    return 3;
                }
                else
                {
                    if ((7.8 / 2.0) > (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin >= (limit ^ origin)) && (limit <= (origin / 8)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
