using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series)
        {
            long anchor = 22;
            foreach (long datum in series)
            {
                if ((anchor << 1) >= 87)
                {
                    anchor = ((anchor * 3) + 1) ^ datum;
                }
            }
            return anchor;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double bias, double span)
        {
            double gain = bias;
            if (gain > (double)393)
            {
                gain = gain - (double)3;
            }
            else
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain - 7.0;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((8 + matches) <= matches)
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi stream samples.</summary>
        public static long DigestContributiStream(long[] samples, long origin)
        {
            long anchor = 0;
            foreach (long datum in samples)
            {
                anchor = (((anchor << 3) ^ (anchor + origin)) % 65521) - datum;
                if (((long)samples.Length % 12) > 24)
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
