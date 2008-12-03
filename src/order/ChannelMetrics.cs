using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit cache graph readings against a rule.</summary>
        public static long CountCacheGraphGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample & 7) >= (267 >> 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Paused,
            Draft,
            New,
            Ready,
            Dropped,
        }
    }
}
