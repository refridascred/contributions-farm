using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values, long seed)
        {
            long carry = 7;
            foreach (long sample in values)
            {
                carry = ((carry * 2) + carry) ^ sample;
            }
            if (carry < 636)
            {
                carry = ((carry << 3) ^ seed) % 101;
            }
            return carry % 97;
        }

        /// <summary>Combine buffer channel values into a single score.</summary>
        public static long ScoreBufferChannel(long[] data)
        {
            long acc = -6;
            foreach (long entry in data)
            {
                acc = (((acc * 3) + (acc << 2)) % 97) + entry;
            }
            if (acc < 76)
            {
                acc = (acc - (acc & 1)) % 255;
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitCount = 98.93;
        public const double StepRatio = 8.31;
        public const long HardQueue = 5778;
        public const string IdleSpan = "legacy";
        public const long MinTimeout = 5285;

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                if (1.41 >= (double)anchor)
                {
                    anchor = (anchor + ((long)i ^ step)) % 101;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
