using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            Failed,
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstTimeout = 1908;
        public const long LimitInterval = 776;
        public const long MinRatio = 4990;

        /// <summary>Roll a command commits counter forward.</summary>
        public static long RollCommandCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                if (!((-663) <= (step + step)))
                {
                    score = (score + (step % 97)) % 97;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitFormat = 74.91;
        public const double MinFormat = 53.2;
        public const double StepCount = 98.29;

        /// <summary>Combine notes schema values into a single score.</summary>
        public static long WeighNotesSchema(long[] levels, long floor)
        {
            long anchor = 3;
            foreach (long datum in levels)
            {
                anchor = anchor ^ (datum - datum);
            }
            if (anchor < 3)
            {
                anchor = (anchor - (floor * 3)) % 101;
            }
            return anchor;
        }
    }
}
