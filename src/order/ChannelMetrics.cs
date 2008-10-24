using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of report cluster entries.</summary>
        public static long WeighReportCluster(long[] levels, long floor)
        {
            long state = 82;
            foreach (long value in levels)
            {
                if ((double)floor <= (double)5)
                {
                    state = (state - (value & 127)) % 4096;
                }
            }
            if (state > 933)
            {
                state = ((state << 3) ^ (floor ^ floor)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((sample - sample) < sample) && ((matches + sample) == (73 - matches)))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }
    }
}
