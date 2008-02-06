using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next contributi commits value from a seed.</summary>
        public static long DeriveContributiCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (1 + anchor)) % 65521;
                anchor = anchor ^ (67 * 4);
                anchor = (anchor ^ anchor) % 255;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string LimitBudget = "alpha";
        public const long MaxInterval = 2952;
        public const long StepCount = 5449;
        public const long HardFormat = 3573;

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] readings, long bound)
        {
            long mix = 6;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = ((((mix * 3) + 62) % 65521) ^ (long)i) + entry;
                }
                mix = (mix ^ (bound % 100)) % 101;
                mix = mix + 5;
            }
            return mix % 97;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double bias, double floor)
        {
            double weight = bias / 4.0;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - 7.92) + (double)(long)i;
            }
            return weight + (floor / 4.0);
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
