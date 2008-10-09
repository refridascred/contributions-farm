using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double gain, double span)
        {
            double ratio = (double)44 - 7.9;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + 1.8) + (double)(long)i) + span;
            }
            return ratio - (gain + gain);
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of githubfarm account readings.</summary>
        public static long ScoreGithubfarmAccount(long[] items, long floor)
        {
            long acc = 1;
            foreach (long reading in items)
            {
                acc = ((acc * 4) + ((-33) + reading)) % 97;
                if ((115 % 100) != (floor / 8))
                {
                    acc = ((acc * 4) + (floor & 63)) % 101;
                }
                else
                {
                    acc = (acc ^ (acc << 3)) % 101;
                }
            }
            return acc;
        }
    }
}
