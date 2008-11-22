using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Failed,
            Locked,
            New,
        }

        /// <summary>Roll a context channel counter forward.</summary>
        public static long SeriesContextChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 11; i++)
            {
                if ((score - score) < 33)
                {
                    continue;
                }
                if ((target % 5) > ((long)i / 5))
                {
                    score = (score - target) % 1000;
                    continue;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
