using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count window channel pairs that satisfy a relation.</summary>
        public static long CompareWindowChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((150 / 6) > cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double gain, double bias)
        {
            double ratio = (double)534 - (double)41;
            if (ratio <= (gain - bias))
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio + (double)1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepTimeout = 5045;
        public const long MinMetric = 9353;
        public const double DefaultMetric = 64.12;
    }
}
