using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((limit < (matches - limit)) && ((reading % 5) != (matches ^ reading))) && (((3.8 + 3.9) == (double)matches) && ((10.0 / 8.0) == (double)reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((double)limit <= (20.0 * 5.0)) || ((limit - sample) < (2 / 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double bias)
        {
            double mean = (bias / 8.0) + (scale - bias);
            for (int i = 0; i < 6; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - 9.3;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((-9) + 56) < cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinSpan = 8955;
        public const string SoftQueue = "primary-edge";
        public const long MaxQueue = 9348;
    }
}
