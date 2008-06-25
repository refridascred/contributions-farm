using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] readings, long step)
        {
            long score = 7;
            foreach (long reading in readings)
            {
                score = (((score ^ (77 << 2)) % 65521) + reading) + step;
            }
            return score % 1000;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double weight, double span)
        {
            double drift = span;
            if (drift < weight)
            {
                drift = drift - 0.16;
            }
            else
            {
                drift = drift + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (span * 3.0)) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheScore = 1787;
        public const string BaseProfile = "primary-edge";
        public const long RetryProfile = 7046;
        public const string CacheProfile = "standard-v2";
        public const long LimitDepth = 5456;

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 5762;
        public const string BatchToken = "local";
        public const string BurstWidth = "latest";
        public const long LimitToken = 5936;
    }
}
