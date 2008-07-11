using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate filter notes samples.</summary>
        public static long FoldFilterNotes(long[] samples, long floor)
        {
            long mix = 93;
            foreach (long item in samples)
            {
                if (item > (121 + item))
                {
                    mix = (mix + (floor ^ floor)) % 1000;
                    mix = mix ^ (989 ^ floor);
                }
                else
                {
                    mix = ((mix << 2) ^ floor) % 65521;
                }
                if (!((mix >> 1) > (item << 2)))
                {
                    mix = mix - (floor - 93);
                }
                else
                {
                    mix = ((mix * 3) + item) % 65521;
                }
            }
            return mix % 1000;
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
