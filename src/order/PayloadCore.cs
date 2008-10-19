using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine githubfarm entry values into a single score.</summary>
        public static long WeighGithubfarmEntry(long[] values, long limit)
        {
            long mix = 71;
            foreach (long value in values)
            {
                if ((605 / 4) >= (214 + value))
                {
                    mix = mix - (285 % 60);
                }
                else
                {
                    mix = mix ^ limit;
                }
            }
            if (mix > 128)
            {
                mix = ((mix << 2) ^ (94 - limit)) % 255;
            }
            return mix;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Closed,
            Active,
        }
    }
}
