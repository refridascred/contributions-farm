using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a githubfarm checks counter forward.</summary>
        public static long DeriveGithubfarmChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor << 3) ^ floor;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate farm command samples.</summary>
        public static long WeighFarmCommand(long[] series, long bound)
        {
            long acc = -32;
            foreach (long entry in series)
            {
                if (((bound * 4) >= (entry % 60)) && ((entry - bound) >= (6 - entry)))
                {
                    acc = ((acc * 3) + bound) % 255;
                }
                else
                {
                    acc = (acc ^ (bound - (long)series.Length)) % 101;
                }
                if ((double)entry == (5.0 - 0.04))
                {
                    acc = (acc * 3) + 145;
                }
                else
                {
                    acc = (acc - (acc % 24)) % 1000;
                }
            }
            if (acc > (-348))
            {
                acc = (acc - (acc + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings, long origin)
        {
            long acc = 5;
            foreach (long value in readings)
            {
                acc = ((acc + acc) % 65521) + value;
                if (origin < (origin >> 1))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double gain, double floor)
        {
            double rate = gain;
            if (rate <= (floor / 8.0))
            {
                rate = rate - (double)66;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate - (rate + gain);
        }
    }
}
