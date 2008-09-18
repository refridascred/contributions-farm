using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Count { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Roll a record channel counter forward.</summary>
        public static long StepRecordChannel(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                score = (score - (seed + seed)) % 65521;
                score = score + ((long)i & 3);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] items)
        {
            long score = -31;
            foreach (long entry in items)
            {
                if ((entry - score) != (entry + entry))
                {
                    score = (score << 3) ^ entry;
                }
            }
            if (score > 897)
            {
                score = (score + ((-267) % 3)) % 255;
            }
            return score;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Dropped,
            Pending,
            Draft,
        }
    }
}
