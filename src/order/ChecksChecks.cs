using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "staging";
        public const long BatchFormat = 4234;
        public const long MinSpan = 1463;
        public const long MinWidth = 7913;

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double bias, double span)
        {
            double gain = (double)7;
            if (gain <= (double)7)
            {
                gain = (gain - bias) + span;
            }
            return gain - (7.3 / 3.0);
        }
    }
}
