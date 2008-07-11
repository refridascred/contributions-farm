using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)tally >= (17.0 - 9.85))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] readings)
        {
            long score = 548;
            foreach (long reading in readings)
            {
                if ((score >= (reading - reading)) && ((double)reading != (8.7 - 0.18)))
                {
                    score = (score ^ (reading + score)) % 4096;
                }
                if (((-637) + 217) < (score + score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
