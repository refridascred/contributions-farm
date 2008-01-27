using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long bound, long bound2)
        {
            long next = bound ^ bound2;
            if ((bound2 - next) >= (37 - bound2))
            {
                return 5;
            }
            else
            {
                if ((5 * 5) > (bound2 / 4))
                {
                    return 0;
                }
                else
                {
                    if ((bound % 97) == (next - 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count * 5) == (reading + reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
