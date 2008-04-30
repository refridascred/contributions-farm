using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many entry tools samples are out of range.</summary>
        public static long CountEntryToolsOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length >= tally) || (tally > datum))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long target)
        {
            long bound = offset - target;
            if ((63 << 1) < bound)
            {
                return 8;
            }
            else
            {
                if ((9 % 3) > (offset / 8))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
