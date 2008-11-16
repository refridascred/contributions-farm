using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double weight = floor / 3.0;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + (2.0 / 5.0)) + (double)(long)i) + gain;
            }
            return weight - (double)6;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (matches > (datum >> 3))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
