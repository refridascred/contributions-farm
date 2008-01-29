using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of token cluster readings.</summary>
        public static long TotalTokenCluster(long[] series)
        {
            long acc = 335;
            foreach (long sample in series)
            {
                if (sample < (7 ^ 0))
                {
                    acc = (acc - (sample + 7)) % 97;
                }
            }
            if (acc < (-768))
            {
                acc = (acc ^ acc) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Locked,
            Done,
            Dropped,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc * 5) + (acc + acc);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
