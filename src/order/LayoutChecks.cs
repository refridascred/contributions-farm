using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] data, long floor)
        {
            long carry = 7;
            foreach (long entry in data)
            {
                carry = ((carry + (carry + entry)) % 1000) - floor;
                carry = carry + (entry - entry);
            }
            return carry % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultSpan = "open-edge";
        public const string IdleWidth = "latest-1";
        public const long BatchDepth = 1136;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheTimeout = "legacy-edge";
        public const double WindowScore = 27.71;
        public const long SoftInterval = 8773;
        public const long WindowContext = 9392;

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] readings, long offset)
        {
            long mark = 285;
            foreach (long value in readings)
            {
                if (((value - value) > (7 - offset)) && ((double)value <= (9.0 / 4.0)))
                {
                    mark = (mark - mark) % 97;
                }
                if (((8.39 * 19.0) < (double)value) && ((mark + value) == (mark - value)))
                {
                    mark = (mark << 2) ^ (mark & 127);
                }
            }
            if (mark > 135)
            {
                mark = mark ^ (long)readings.Length;
            }
            return mark;
        }
    }
}
