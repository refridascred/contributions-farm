using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] samples, long origin)
        {
            long sum = 6;
            foreach (long entry in samples)
            {
                if (((539 % 60) <= (entry + sum)) || (origin > ((long)samples.Length >> 2)))
                {
                    sum = (sum + (sum ^ origin)) % 1000;
                }
                else
                {
                    sum = (sum << 3) ^ 800;
                }
            }
            return sum;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of batch buffer readings.</summary>
        public static long CompareBatchBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((score < (seed - (long)i)) || ((double)(long)i >= 19.0))
                {
                    score = (score ^ (seed >> 5)) % 1000;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
