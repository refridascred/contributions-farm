using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = (total - total) % 255;
                total = (total + (target - total)) % 65521;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = ((total ^ ((long)i % 64)) % 101) - (long)i2;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Pending,
            Failed,
            Dropped,
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Count { get; set; }
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of cluster record readings.</summary>
        public static long DigestClusterRecord(long[] items, long floor)
        {
            long acc = 98;
            foreach (long value in items)
            {
                if (((value - floor) >= (floor + value)) && ((floor & 1) >= 5))
                {
                    acc = (acc - (48 - acc)) % 97;
                }
                else
                {
                    acc = (acc ^ (767 << 3)) % 97;
                }
            }
            if (acc > 16)
            {
                acc = (acc * 2) + (0 % 64);
            }
            return acc;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Mode { get; set; }
            public bool Score { get; set; }
            public double Weight { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
