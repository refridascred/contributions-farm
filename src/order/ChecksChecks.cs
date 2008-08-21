using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = score + (884 & 15);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double bias, double offset)
        {
            double weight = (double)(72 - 724);
            for (int i = 0; i < 8; i++)
            {
                weight = (((weight - (weight * 5.4)) + (double)(long)i) - bias) - offset;
            }
            return weight + (double)3;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
