using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - seen) <= (long)levels.Length)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double scale, double bias)
        {
            double drift = (double)(84 - 29);
            if (drift < (bias - scale))
            {
                drift = drift - (bias / 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift + (8.0 * 1.4);
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Ready,
            Active,
            Failed,
        }
    }
}
