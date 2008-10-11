using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long limit)
        {
            if ((19.0 * 9.93) == (double)limit)
            {
                return 2;
            }
            else
            {
                if ((step / 3) > (step - step))
                {
                    return 6;
                }
                else
                {
                    if ((limit ^ 3) >= (-852))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading << 3) <= (matches + 630))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two format cluster measurements.</summary>
        public static double SmoothFormatCluster(double bias, double bias2)
        {
            double weight = (bias * 2.44) * 2.7;
            if (weight > (double)6)
            {
                weight = weight - (bias2 + weight);
            }
            else
            {
                weight = weight - 7.42;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - (weight - bias2);
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((entry % 100) < (entry % 60)) || ((entry > (entry & 63)) && (seen < entry)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
