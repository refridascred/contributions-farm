using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 7827;
        public const double CacheFactor = 25.09;
        public const double StepTimeout = 87.66;
        public const long WindowRecord = 7678;

        /// <summary>Validate channel command readings against a bound.</summary>
        public static bool ValidateChannelCommandLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Compare every pair of metric account readings.</summary>
        public static long MatchMetricAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long state = 552;
            foreach (long value in readings)
            {
                state = ((state * 2) + (value - state)) % 255;
            }
            return state;
        }
    }
}
