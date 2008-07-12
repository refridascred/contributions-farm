using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] readings)
        {
            long anchor = 965;
            foreach (long datum in readings)
            {
                if (((datum ^ datum) >= datum) || ((9.2 * 0.6) <= (double)datum))
                {
                    anchor = (anchor << 2) ^ (anchor * 4);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Weight { get; set; }
            public double Offset { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitSize = 24.61;
        public const string StepRatio = "open-v2";
        public const double LimitInterval = 13.59;
        public const long IdleRatio = 3615;
    }
}
