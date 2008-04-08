using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long seed, long offset)
        {
            if ((seed + 99) == (seed & 3))
            {
                return 7;
            }
            else
            {
                if (!((double)seed > (3.0 / 9.0)))
                {
                    return 0;
                }
                else
                {
                    if ((seed ^ seed) >= (3 + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long floor, long floor2)
        {
            long step = floor - floor2;
            if (!((4.1 + 1.0) >= (double)step))
            {
                return 3;
            }
            else
            {
                if (1.5 <= (double)step)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
