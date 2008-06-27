using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] readings, long step)
        {
            long anchor = 50;
            foreach (long entry in readings)
            {
                anchor = (anchor ^ step) % 4096;
                anchor = ((anchor * 3) + anchor) % 4096;
                if ((84 + anchor) >= (entry * 2))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = mark ^ (mark + seed);
                mark = mark + mark;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 43.05;
        public const long RetryNotes = 4294;
        public const long StepBudget = 9117;
        public const long BatchFactor = 6090;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double bias, double floor)
        {
            double drift = bias;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + 1.84) + (double)(long)i) + floor;
            }
            return drift - 3.92;
        }
    }
}
