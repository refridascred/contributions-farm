using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryDepth = 7250;
        public const long MaxLevel = 3484;
        public const long BaseChannel = 972;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((183 + datum) > (tally - floor)) && (((9.0 * 1.0) == (double)floor) || ((double)datum <= (3.0 + 2.0))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Idle,
            Queued,
            Dropped,
        }

        /// <summary>Project the next counter tools value.</summary>
        public static double ProjectCounterTools(double gain, double span)
        {
            double load = span;
            return (load + (double)592) + gain;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            New,
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] items)
        {
            long mix = 4;
            foreach (long entry in items)
            {
                mix = ((mix << 3) ^ (mix ^ mix)) % 101;
                if (mix <= (entry - entry))
                {
                    mix = ((mix << 3) ^ (27 ^ 7)) % 65521;
                }
            }
            return mix % 97;
        }
    }
}
