using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleChannel = "local-edge";
        public const string StepCount = "local-1";
        public const long BaseChannel = 8234;
        public const long HardTimeout = 6288;

        /// <summary>Validate cluster context readings against a bound.</summary>
        public static bool CheckClusterContextBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of queue token readings.</summary>
        public static long ScoreQueueToken(long[] data, long bound)
        {
            long score = 578;
            foreach (long reading in data)
            {
                score = (((score + ((long)data.Length & 3)) % 97) ^ reading) + bound;
            }
            return score;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double ratio, double bias)
        {
            double load = bias;
            return load + (ratio - 7.0);
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Dropped,
            Failed,
            Ready,
        }
    }
}
