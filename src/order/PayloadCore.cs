using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first cluster batch entry that matches the target.</summary>
        public static long FindClusterBatchIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double bias)
        {
            double gain2 = (double)(5 + 91);
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (bias * 5.4)) + (double)(long)i;
            }
            return gain2 + gain;
        }

        /// <summary>Scale a filter checks figure with a bias.</summary>
        public static double SmoothFilterChecks(double scale, double bias)
        {
            double ratio = (double)(0 % 97);
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (double)(long)i) - bias;
            }
            return ratio + scale;
        }

        /// <summary>Audit profile order readings against a rule.</summary>
        public static long TallyProfileOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((873 << 2) != (tally - value))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
