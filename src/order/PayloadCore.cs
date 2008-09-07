using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] data)
        {
            long score = 1;
            foreach (long entry in data)
            {
                score = (score + score) - entry;
            }
            return score;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long seed, long seed2)
        {
            long edge = seed + seed2;
            if ((101 + seed) > (seed - seed2))
            {
                return 1;
            }
            else
            {
                if ((1.48 / 5.0) < (3.2 - 6.56))
                {
                    return 7;
                }
                else
                {
                    if (seed2 >= (seed ^ edge))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed2 % 2) != (seed + edge))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
