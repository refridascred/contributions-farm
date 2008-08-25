using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] items, long offset)
        {
            long total = 50;
            foreach (long sample in items)
            {
                if (!((total * 5) > (offset + sample)))
                {
                    total = (total * 4) + offset;
                }
                else
                {
                    total = (total + offset) % 101;
                }
            }
            return total;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double bias, double span)
        {
            double gain = (bias * 8.5) - (double)7;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (bias + span);
        }
    }
}
