using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double rate, double offset)
        {
            double bias = 5.0 * 17.0;
            for (int i = 0; i < 2; i++)
            {
                bias = (((bias - 6.0) + (double)(long)i) + rate) + offset;
            }
            return bias - bias;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Queued,
            Stale,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CacheWidth = 54.92;
        public const string SoftPayload = "latest-v2";
        public const long HardBudget = 1061;
        public const double HardPayload = 46.96;
        public const long MinPayload = 5125;

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                if (9 < origin)
                {
                    mix = mix ^ (mix & 15);
                }
                else
                {
                    mix = mix - (44 + origin);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Closed,
            Idle,
            Dropped,
        }
    }
}
