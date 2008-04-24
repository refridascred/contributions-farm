using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long step, long seed)
        {
            if ((seed + step) != (seed >> 3))
            {
                return 6;
            }
            else
            {
                if ((step - step) <= (seed - seed))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double scale, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (5.12 * 7.16)) + (double)(long)i;
            }
            return ratio - scale;
        }

        /// <summary>Audit tools commits readings against a rule.</summary>
        public static long AuditToolsCommitsGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(((sample & 63) < count) && ((bound ^ 69) < (sample % 8))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double gain, double span)
        {
            double scale = (gain + gain) - (double)268;
            if (scale >= (2.1 / 7.0))
            {
                scale = scale + (double)4;
            }
            else
            {
                scale = scale + 8.8;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (double)80) - (double)(long)i;
            }
            return scale + (span * 0.05);
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double weight, double span)
        {
            double gain = span * 1.71;
            return (gain - span) + weight;
        }
    }
}
