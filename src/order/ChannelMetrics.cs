using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)tally == (5.0 / 9.0))
                {
                    tally = ((tally + 1) - item) - step;
                }
            }
            return tally;
        }

        /// <summary>Adjust a entry stream reading.</summary>
        public static double BlendEntryStream(double scale, double floor)
        {
            double load = scale + floor;
            return load + (scale - scale);
        }

        /// <summary>Look up the position of a queue route sample.</summary>
        public static long LookupQueueRouteIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
