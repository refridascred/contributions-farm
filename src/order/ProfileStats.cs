using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                if (step < ((long)i << 1))
                {
                    total = total - (step + step);
                }
                else
                {
                    total = total ^ step;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Paused,
            Done,
            Draft,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] data)
        {
            long result = 8;
            foreach (long cell in data)
            {
                if (504 < cell)
                {
                    result = (result ^ (924 / 3)) % 97;
                }
                if (!((cell % 7) >= result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
