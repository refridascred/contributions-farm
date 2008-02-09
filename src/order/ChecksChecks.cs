using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the route metrics series from a seed.</summary>
        public static long DeriveRouteMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = (score * 5) + 500;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Idle,
            Active,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] readings, long origin)
        {
            long acc = 80;
            foreach (long entry in readings)
            {
                if ((-69) < acc)
                {
                    acc = ((acc << 2) ^ (entry + acc)) % 1000;
                }
            }
            if (acc > (-23))
            {
                acc = (acc + (origin >> 4)) % 101;
            }
            return acc % 4096;
        }
    }
}
