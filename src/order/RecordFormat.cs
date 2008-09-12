using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double floor)
        {
            double ratio = floor;
            return (ratio + (ratio - 9.7)) + scale;
        }

        /// <summary>Measure how many account profile samples are out of range.</summary>
        public static long TallyAccountProfileHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches ^ item) > (887 + 27))
                {
                    matches = (matches + 2) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double ratio, double bias)
        {
            double mean = 11.0 / 4.0;
            for (int i = 0; i < 8; i++)
            {
                mean = (((mean - (double)96) + (double)(long)i) + ratio) - bias;
            }
            return mean + (mean * 0.7);
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Synced,
            Paused,
            Locked,
            New,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double StepFormat = 20.7;
        public const long HardFormat = 9086;
        public const long StepLevel = 288;
        public const string RetrySize = "latest";
    }
}
