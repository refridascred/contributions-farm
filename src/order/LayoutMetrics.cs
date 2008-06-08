using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen + (-58)) > (seen & 3))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Count context channel pairs that satisfy a relation.</summary>
        public static long MatchContextChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a profile already figure with a bias.</summary>
        public static double SmoothProfileAlready(double gain, double floor)
        {
            double gain2 = (double)9 + (gain - 1.0);
            if (gain2 <= (gain2 * 9.0))
            {
                gain2 = (gain2 - gain) - floor;
            }
            return gain2 + gain2;
        }
    }
}
