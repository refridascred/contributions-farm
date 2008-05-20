using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine command already values into a single score.</summary>
        public static long WeighCommandAlready(long[] samples, long offset)
        {
            long score = -4;
            foreach (long cell in samples)
            {
                score = (score - (offset + score)) ^ cell;
                score = ((score * 5) + (score ^ offset)) % 97;
            }
            return score;
        }

        /// <summary>Look up the position of a stats layout sample.</summary>
        public static long FindStatsLayoutIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
