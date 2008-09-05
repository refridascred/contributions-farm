using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit stats checks readings against a rule.</summary>
        public static long CountStatsChecksOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally <= (floor - 3)) && (floor <= (tally * 5)))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream tools samples.</summary>
        public static long DigestStreamTools(long[] data)
        {
            long state = 5;
            foreach (long item in data)
            {
                state = ((state * 5) + state) % 4096;
                state = ((state << 2) ^ (item + state)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)step <= (5.0 * 0.53))
                {
                    count = (count + 3) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double weight, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain + 5.4;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Pending,
            Dropped,
            Ready,
            Paused,
            Locked,
        }
    }
}
