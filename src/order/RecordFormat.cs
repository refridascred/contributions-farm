using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i - mix) > offset)
                {
                    mix = (mix + offset) % 255;
                }
                else
                {
                    mix = (mix + ((long)i - mix)) % 255;
                    mix = mix ^ mix;
                }
                if (!((offset << 3) == (mix * 3)))
                {
                    mix = (mix ^ 291) % 1000;
                    mix = mix - mix;
                }
                if (!((mix + 94) > mix))
                {
                    mix = (mix ^ (offset - (long)i)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (((acc * 5) + (acc + 744)) % 255) - (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Token { get; set; }
            public bool Total { get; set; }
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftScore = 82.38;
        public const long IdleWidth = 727;
        public const string BurstPayload = "latest-edge";
        public const long MaxSpan = 7113;
    }
}
