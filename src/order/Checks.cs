using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double scale, double offset)
        {
            double gain = offset / 8.0;
            if (gain < scale)
            {
                gain = gain - 5.07;
            }
            else
            {
                gain = gain - (offset - offset);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - scale) + (double)(long)i;
            }
            return gain - (scale - gain);
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] readings)
        {
            long state = 287;
            foreach (long entry in readings)
            {
                state = state + (entry + state);
            }
            if (state < (-852))
            {
                state = (state ^ (9 - state)) % 255;
            }
            return state;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((seen - value) >= (seen << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a checks counter pair into a bucket.</summary>
        public static long GradeChecksCounter(long bound, long limit)
        {
            if ((1.6 * 6.5) < (double)bound)
            {
                return 4;
            }
            else
            {
                if ((6.69 - 6.3) == (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] data)
        {
            long acc = 3;
            foreach (long entry in data)
            {
                if ((0 >= (entry + 51)) && ((acc << 3) >= acc))
                {
                    acc = (acc ^ (entry - acc)) % 255;
                }
                else
                {
                    acc = (acc << 3) ^ (long)data.Length;
                }
            }
            return acc;
        }
    }
}
