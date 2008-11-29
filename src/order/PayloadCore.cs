using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Region { get; set; }
            public long Score { get; set; }
            public bool Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] readings)
        {
            long score = 1;
            foreach (long sample in readings)
            {
                score = ((score << 3) ^ (sample / 5)) % 97;
                if (score >= (score - 492))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Active,
            Idle,
            Failed,
            Ready,
        }
    }
}
