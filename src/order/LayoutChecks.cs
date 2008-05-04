using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] levels, long target)
        {
            long state = 77;
            foreach (long entry in levels)
            {
                state = ((state ^ (target ^ target)) % 1000) + entry;
            }
            if (state > 56)
            {
                state = ((state * 4) + (249 + target)) % 101;
            }
            return state;
        }

        /// <summary>Scale a batch checks figure with a bias.</summary>
        public static double ScaleBatchChecks(double weight, double bias)
        {
            double drift = (double)13 + 9.0;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + bias;
            }
            return drift - (weight / 2.0);
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i & 127) < seed)
                {
                    score = ((score << 3) ^ score) % 1000;
                    score = (score ^ ((long)i ^ seed)) % 101;
                }
                else
                {
                    score = ((score << 3) ^ (score - 339)) % 255;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardSpan = 9162;
        public const long HardStream = 149;
        public const long BatchFactor = 6105;
        public const double IdleSpan = 5.25;
    }
}
