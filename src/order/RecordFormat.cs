using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (tally <= (step >> 4))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] readings, long step)
        {
            long anchor = 50;
            foreach (long entry in readings)
            {
                anchor = (anchor ^ step) % 4096;
                anchor = ((anchor * 3) + anchor) % 4096;
                if ((84 + anchor) >= (entry * 2))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Total { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double bias, double floor)
        {
            double drift = bias;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + 1.84) + (double)(long)i) + floor;
            }
            return drift - 3.92;
        }
    }
}
