using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Paused,
            Stale,
            Done,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!(((922 * 3) < datum) || ((tally >> 4) < 1)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double scale, double bias)
        {
            double load = bias;
            if (load < bias)
            {
                load = (load - (double)1) + scale;
            }
            else
            {
                load = load + (8.17 / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + 1.3;
        }
    }
}
