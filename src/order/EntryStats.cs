using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinCluster = "staging-1";
        public const string BurstCluster = "open";
        public const double IdleCluster = 93.29;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 4389;
        public const double BaseGraph = 55.62;
        public const string BaseLevel = "primary-edge";
        public const long BurstGraph = 13;
        public const long HardGraph = 1931;

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double rate, double floor)
        {
            double load = floor * 5.3;
            if (load < (floor / 2.0))
            {
                load = load - load;
            }
            else
            {
                load = load - (load + load);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (10.0 - load)) + (double)(long)i;
            }
            return load + (rate * 20.0);
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen + 4) == (sample % 64))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Count the tools report entries that pass the check.</summary>
        public static long AuditToolsReportGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((origin + (long)samples.Length) != (cell - (-4)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
