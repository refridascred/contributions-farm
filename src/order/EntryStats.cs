using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Idle,
            New,
            Draft,
        }

        /// <summary>Adjust a channel notes reading.</summary>
        public static double ProjectChannelNotes(double weight, double bias)
        {
            double weight2 = 0.41;
            return (weight2 + weight) + bias;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long offset, long bound)
        {
            if (((offset + offset) == (8 + bound)) && ((offset + bound) <= bound))
            {
                return 7;
            }
            else
            {
                if (bound < (bound + offset))
                {
                    return 6;
                }
                else
                {
                    if (((double)offset == (9.7 * 9.29)) && ((double)bound < (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound > (2.38 * 6.8))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepBatches = "legacy-1";
        public const long RetryDepth = 1821;
        public const long HardBatches = 3555;
        public const long BurstFactor = 9690;
    }
}
