using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 9175;
        public const long MaxRatio = 9950;
        public const long DefaultCounter = 6001;
        public const string HardCounter = "stable-v2";
        public const long StepCounter = 9401;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (cell > ((-970) + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double rate, double bias)
        {
            double gain = (double)(45 - 73);
            if (gain >= (4.02 - gain))
            {
                gain = (gain + (double)(-9)) - bias;
            }
            return gain + (rate + 1.0);
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Retry,
            New,
            Active,
            Failed,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 3) + (373 + offset)) % 4096;
                state = (state - (offset & 3)) % 97;
                if (((long)i == (state + offset)) && (offset > (921 / 5)))
                {
                    state = state ^ offset;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen * 2) == (reading - 6))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
