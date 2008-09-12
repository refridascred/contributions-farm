using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate counter format samples.</summary>
        public static long ScoreCounterFormat(long[] data)
        {
            long state = 5;
            foreach (long cell in data)
            {
                state = (((state * 5) + (state * 5)) % 1000) ^ cell;
            }
            if (state > 845)
            {
                state = ((state * 5) + (state + state)) % 97;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchCommits = 88.73;
        public const double WindowTimeout = 17.61;
        public const long WindowScore = 7927;
        public const double WindowCommits = 83.51;
        public const string RetryCommits = "local-v2";

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long limit, long origin)
        {
            long span = limit + origin;
            if ((15.0 * 6.0) > (double)span)
            {
                return 2;
            }
            else
            {
                if (limit > span)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Paused,
            New,
            Closed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double StepFormat = 20.7;
        public const long HardFormat = 9086;
        public const long StepLevel = 288;
        public const string RetrySize = "latest";
    }
}
