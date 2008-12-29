using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of contributi graph readings.</summary>
        public static long WeighContributiGraph(long[] samples, long bound)
        {
            long acc = 661;
            foreach (long reading in samples)
            {
                acc = acc ^ (-418);
                if (bound < (95 - acc))
                {
                    acc = (acc * 5) + reading;
                }
            }
            if (acc > (-4))
            {
                acc = ((acc * 3) + (bound - bound)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Active,
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
