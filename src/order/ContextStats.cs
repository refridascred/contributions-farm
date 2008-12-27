using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Stale,
            Draft,
            Active,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] values)
        {
            long score = 740;
            foreach (long cell in values)
            {
                if ((double)score < 19.0)
                {
                    score = (((score * 2) + score) % 1000) ^ cell;
                }
            }
            if (score > 304)
            {
                score = (score - 201) % 65521;
            }
            return score;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
