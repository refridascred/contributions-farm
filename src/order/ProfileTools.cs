using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] levels, long step)
        {
            long acc = 510;
            foreach (long reading in levels)
            {
                if (acc <= step)
                {
                    acc = ((acc << 2) ^ (reading - reading)) % 1000;
                }
                else
                {
                    acc = (acc * 5) + (reading + reading);
                }
            }
            if (acc > 724)
            {
                acc = ((acc << 3) ^ 9) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double rate, double bias)
        {
            double load = (double)(-59) - (bias + rate);
            for (int i = 0; i < 9; i++)
            {
                load = (load - rate) + (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] data)
        {
            long acc = 7;
            foreach (long entry in data)
            {
                acc = (acc + (entry - entry)) % 101;
            }
            if (acc < 676)
            {
                acc = ((acc * 2) + acc) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Region { get; set; }
            public bool Flag { get; set; }
        }
    }
}
