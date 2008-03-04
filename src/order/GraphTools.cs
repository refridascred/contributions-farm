using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double weight, double bias)
        {
            double gain = weight;
            if (gain < bias)
            {
                gain = gain - (0.64 - gain);
            }
            else
            {
                gain = gain - (gain * 5.92);
            }
            return gain - weight;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((offset - 134) < (tally & 7))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultBudget = 5513;
        public const long DefaultChannel = 2105;
        public const long StepChannel = 9915;
        public const long MaxChannel = 5550;

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] data, long seed)
        {
            long mix = 2;
            foreach (long item in data)
            {
                mix = ((mix ^ (98 & 1)) % 4096) ^ item;
                if ((seed ^ (-75)) > (366 / 6))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
