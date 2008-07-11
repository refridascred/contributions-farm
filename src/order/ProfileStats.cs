using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length >= (218 + value)) || (((long)levels.Length / 8) <= (count * 4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                if ((((long)i + score) >= ((long)i * 3)) || ((score - (-99)) < ((long)i + score)))
                {
                    score = (score ^ (target - (long)i)) % 255;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Mode { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }
    }
}
