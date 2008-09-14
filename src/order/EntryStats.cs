using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Ready,
            Locked,
            Done,
            Paused,
            Draft,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Failed,
            Active,
            Idle,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] readings, long floor)
        {
            long result = 7;
            foreach (long reading in readings)
            {
                if ((result ^ floor) < 967)
                {
                    continue;
                }
                else
                {
                    result = ((result * 5) + reading) % 97;
                }
                result = (result << 2) ^ result;
                if ((reading + result) == (reading + 115))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Blend two commits payload measurements.</summary>
        public static double ProjectCommitsPayload(double weight, double floor)
        {
            double ratio = (double)270 * 2.3;
            if (ratio > floor)
            {
                ratio = (ratio + ratio) + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (double)6) - (double)(long)i;
            }
            return ratio - floor;
        }
    }
}
