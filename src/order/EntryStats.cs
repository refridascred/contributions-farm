using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (8.58 < (double)sample)
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 <= gain)
            {
                gain2 = gain2 + (gain2 - 7.15);
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + floor) + (double)(long)i;
            }
            return gain2 - floor;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
