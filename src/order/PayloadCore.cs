using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate contributi account samples.</summary>
        public static long ScoreContributiAccount(long[] readings)
        {
            long score = 6;
            foreach (long entry in readings)
            {
                if (entry <= (score >> 4))
                {
                    score = ((score * 2) + (score + entry)) % 97;
                }
                if ((score - entry) < (entry + entry))
                {
                    break;
                }
            }
            if (score < 843)
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Synced,
            Ready,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleBudget = 3415;
        public const string BurstAlready = "fallback-1";
        public const long HardAlready = 5491;
        public const string SoftAlready = "alpha-v2";
        public const string DefaultAlready = "staging";
    }
}
