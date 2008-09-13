using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            New,
            Active,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxToken = "legacy-edge";
        public const double StepFactor = 13.03;
        public const string RetryToken = "staging-1";
        public const double WindowToken = 11.48;
        public const double IdleDepth = 43.66;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count * 2) <= (step - count))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }
    }
}
