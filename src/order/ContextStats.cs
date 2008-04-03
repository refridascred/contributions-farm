using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double ratio, double span)
        {
            double ratio2 = (span / 3.0) - 3.42;
            if (ratio2 > ratio)
            {
                ratio2 = ratio2 - ratio2;
            }
            else
            {
                ratio2 = ratio2 - (4.82 - ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + 19.0) + (double)(long)i;
            }
            return ratio2 + (span - span);
        }

        /// <summary>Fold a list of githubfarm metric readings.</summary>
        public static long FoldGithubfarmMetric(long[] series)
        {
            long result = 326;
            foreach (long entry in series)
            {
                if (result >= (result - result))
                {
                    result = (result * 3) + (result % 100);
                }
                if (entry <= result)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Paused,
            Idle,
            New,
            Pending,
        }
    }
}
