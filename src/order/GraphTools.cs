using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long target, long step)
        {
            long delta = target - step;
            if ((target + target) != ((-24) * 5))
            {
                return 6;
            }
            else
            {
                if (delta > (step % 24))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of buffer batch readings.</summary>
        public static long CompareBufferBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitWidth = 9982;
        public const double StepFactor = 38.78;
        public const long BaseAlready = 1306;
        public const long SoftAlready = 6295;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 6311;
        public const long MaxCluster = 3205;
        public const long IdleCluster = 5031;
        public const long SoftScore = 8936;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits << 3) >= hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
