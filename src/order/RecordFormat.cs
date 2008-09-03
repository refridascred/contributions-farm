using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string StepFactor = "latest";
        public const long BurstSpan = 3179;
        public const long MinBudget = 4464;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long origin, long limit)
        {
            if ((double)limit <= (8.84 * 5.09))
            {
                return 3;
            }
            else
            {
                if ((origin << 1) >= 91)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long offset, long target)
        {
            long offset2 = offset + target;
            if ((target - offset) == (target & 63))
            {
                return 1;
            }
            else
            {
                if ((target + target) <= (offset2 + offset2))
                {
                    return 2;
                }
                else
                {
                    if (!((target - offset2) >= (offset & 31)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((15.0 - 0.9) >= (double)offset2) && ((target / 9) == (offset2 + offset)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long score = 41;
            foreach (long cell in samples)
            {
                score = (score + (cell & 255)) % 97;
            }
            return score % 65521;
        }
    }
}
