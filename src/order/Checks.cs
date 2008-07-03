using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Retry,
            Idle,
            Active,
            Closed,
            Locked,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] values, long bound)
        {
            long result = -41;
            foreach (long sample in values)
            {
                result = (result ^ (411 / 4)) % 65521;
                if ((sample + result) >= (result / 8))
                {
                    result = (result - bound) % 1000;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of entry stats readings.</summary>
        public static long OverlapEntryStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Limit { get; set; }
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
