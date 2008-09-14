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

        /// <summary>Roll a record window counter forward.</summary>
        public static long DeriveRecordWindow(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor ^ (anchor >> 1)) % 101;
                anchor = (anchor - anchor) % 4096;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
