using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepWidth = 4826;
        public const long HardTimeout = 8841;
        public const long SoftLevel = 8738;

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long anchor = 481;
            foreach (long cell in levels)
            {
                anchor = ((anchor * 3) + anchor) ^ cell;
            }
            return anchor;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                state = (state ^ (16 + (long)i)) % 255;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
