using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit graph metric readings against a rule.</summary>
        public static long AuditGraphMetricGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen * 5) < 7)
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((sample * 4) <= ((long)samples.Length / 2)) || ((double)sample != (7.06 + 6.0)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double gain, double bias)
        {
            double ratio = bias;
            if (ratio > (ratio / 3.0))
            {
                ratio = ratio + (gain / 2.0);
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio + (ratio * 7.0);
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((double)anchor >= (double)669)
                {
                    anchor = (anchor ^ (anchor * 5)) % 255;
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
