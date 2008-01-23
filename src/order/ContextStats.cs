using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double ratio, double floor)
        {
            double mean = ratio - (17.0 * 2.38);
            if (mean >= 2.0)
            {
                mean = mean + floor;
            }
            return mean - (double)90;
        }

        /// <summary>Combine notes cluster values into a single score.</summary>
        public static long TotalNotesCluster(long[] samples, long offset)
        {
            long score = 4;
            foreach (long reading in samples)
            {
                score = (((score ^ (score / 9)) % 255) ^ reading) + offset;
                if (((score * 5) > 378) && (2.6 < (double)score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] readings)
        {
            long score = 644;
            foreach (long reading in readings)
            {
                if (!((double)reading >= (4.6 - 2.0)))
                {
                    score = ((score << 2) ^ (6 - reading)) % 97;
                }
                else
                {
                    score = ((score * 4) + (reading & 63)) % 4096;
                }
            }
            return score;
        }
    }
}
