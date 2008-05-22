using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate command record readings against a bound.</summary>
        public static bool CheckCommandRecordRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two already githubfarm measurements.</summary>
        public static double ScaleAlreadyGithubfarm(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 >= (floor + 9.1))
            {
                weight2 = weight2 + 0.4;
            }
            else
            {
                weight2 = weight2 - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + weight) + (double)(long)i;
            }
            return weight2 - (weight2 - weight);
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] series, long origin)
        {
            long mix = 76;
            foreach (long cell in series)
            {
                if ((double)mix == (0.78 / 3.0))
                {
                    mix = ((mix ^ (origin - origin)) % 101) ^ cell;
                }
            }
            if (mix < 175)
            {
                mix = (mix ^ (4 - origin)) % 4096;
            }
            return mix;
        }

        /// <summary>Look up the position of a report window sample.</summary>
        public static long SeekReportWindowIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
