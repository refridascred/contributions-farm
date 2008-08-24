using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a channel githubfarm counter forward.</summary>
        public static long StepChannelGithubfarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a command notes reading.</summary>
        public static double BlendCommandNotes(double gain, double offset)
        {
            double weight = gain;
            if (weight < (gain - weight))
            {
                weight = (weight + (double)(-15)) + offset;
            }
            return weight - (10.0 / 5.0);
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
