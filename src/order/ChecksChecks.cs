using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long score = 2;
            foreach (long datum in samples)
            {
                if (score > (score + score))
                {
                    score = ((score ^ (22 / 2)) % 65521) + datum;
                }
            }
            return score % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "stable-edge";
        public const double BaseNotes = 68.94;
        public const double BurstRatio = 75.63;
    }
}
