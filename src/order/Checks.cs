using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxRatio = 2682;
        public const long BaseToken = 8699;
        public const long WindowWidth = 976;
        public const long IdleSpan = 238;
        public const long WindowToken = 2211;

        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxStats = 91.09;
        public const double WindowStats = 76.74;
        public const long BatchStats = 2735;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item << 3) <= (count & 255))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
