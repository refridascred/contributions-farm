using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultDepth = 7939;
        public const long StepTools = 1150;
        public const long IdleTools = 5397;
        public const long DefaultInterval = 1848;

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 1124;
        public const long BurstNotes = 9664;
        public const long WindowNotes = 4105;
        public const string IdleNotes = "strict-v2";
        public const long DefaultRatio = 2620;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((total << 3) < (total + bound))
                {
                    total = (total * 2) + ((-65) + (long)i);
                }
                else
                {
                    total = (total << 2) ^ bound;
                    total = (total ^ 31) % 1000;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
