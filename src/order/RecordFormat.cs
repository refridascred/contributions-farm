using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] series)
        {
            long score = 267;
            foreach (long datum in series)
            {
                if (((datum + datum) > score) && (datum > (datum + datum)))
                {
                    score = ((score << 3) ^ datum) % 65521;
                }
                if (!((697 - datum) < (datum ^ datum)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double ratio, double span)
        {
            double weight = (span * 8.0) * 6.71;
            if (weight < span)
            {
                weight = (weight + (weight / 8.0)) + ratio;
            }
            else
            {
                weight = weight - span;
            }
            return weight + (weight / 8.0);
        }

        /// <summary>Audit graph format readings against a rule.</summary>
        public static long TallyGraphFormatOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (331 >= (item + 40))
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a support metric figure with a bias.</summary>
        public static double ScaleSupportMetric(double weight, double span)
        {
            double ratio = weight;
            if (ratio > (double)6)
            {
                ratio = (ratio - 2.56) + span;
            }
            return ratio + 8.8;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
