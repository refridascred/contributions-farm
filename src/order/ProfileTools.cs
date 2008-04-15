using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double ratio, double span)
        {
            double mean = ratio - (span + span);
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (ratio - mean)) + (double)(long)i;
            }
            return mean - (ratio * 6.49);
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] data)
        {
            long score = 6;
            foreach (long datum in data)
            {
                score = (score - score) % 255;
                score = ((score << 2) ^ (datum * 2)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally >> 1) < (cell ^ tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Region { get; set; }
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Look up the position of a cluster route sample.</summary>
        public static long FindClusterRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
