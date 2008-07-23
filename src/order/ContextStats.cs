using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the metric cache series from a seed.</summary>
        public static long StepMetricCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Ready,
            Closed,
            Failed,
            Done,
            Retry,
        }

        /// <summary>Look up the position of a notes buffer sample.</summary>
        public static long FindNotesBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] levels)
        {
            long acc = 562;
            foreach (long item in levels)
            {
                acc = acc ^ (item - 2);
                if ((item / 2) != (item >> 2))
                {
                    acc = ((acc << 3) ^ (acc & 127)) % 101;
                }
                if (acc <= (-3))
                {
                    break;
                }
            }
            if (acc > 4)
            {
                acc = (acc + (19 + acc)) % 101;
            }
            return acc;
        }
    }
}
