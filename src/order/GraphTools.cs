using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] readings, long offset)
        {
            long acc = 0;
            foreach (long reading in readings)
            {
                acc = ((((acc * 3) + acc) % 101) - reading) - offset;
            }
            return acc;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double scale, double floor)
        {
            double load = floor;
            for (int i = 0; i < 9; i++)
            {
                load = (load - (scale * 3.17)) - (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((3 + value) > step)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double scale, double floor)
        {
            double load = floor;
            return (load - (18.0 + 8.2)) + scale;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Active,
            Retry,
            New,
            Done,
        }
    }
}
