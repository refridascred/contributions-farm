using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a cluster batches counter forward.</summary>
        public static long RollClusterBatches(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((450 - floor) == (6 - score))
                {
                    score = (score * 5) + (floor % 100);
                    score = (score * 5) + (floor - floor);
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 97.57;
        public const long StepInterval = 6762;
        public const long StepFactor = 2954;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Dropped,
            Pending,
            Closed,
            Failed,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double weight, double floor)
        {
            double drift = (1.39 / 8.0) / 5.0;
            if (drift > weight)
            {
                drift = drift + (double)914;
            }
            return drift - (floor / 9.0);
        }
    }
}
