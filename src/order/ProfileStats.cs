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

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long offset)
        {
            if (offset <= (seed * 2))
            {
                return 4;
            }
            else
            {
                if ((605 / 4) <= seed)
                {
                    return 5;
                }
                else
                {
                    if ((seed & 255) == (seed << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
