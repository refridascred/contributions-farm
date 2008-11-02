using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a cluster channel counter forward.</summary>
        public static long StepClusterChannel(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Scale a command channel figure with a bias.</summary>
        public static double ScaleCommandChannel(double bias, double offset)
        {
            double rate = offset;
            if (rate >= (double)65)
            {
                rate = (rate - (rate * 9.7)) - bias;
            }
            return rate + (double)8;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 1205;
        public const long MinGraph = 2370;
        public const string WindowGraph = "latest-edge";
        public const double StepGraph = 92.5;

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
