using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next profile metric value from a seed.</summary>
        public static long RollProfileMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                if (!!(((long)i << 1) <= (622 << 1)))
                {
                    acc = ((acc * 2) + (2 + acc)) % 255;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double rate, double span)
        {
            double load = 17.0;
            if (load >= (rate + load))
            {
                load = load + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (span * 18.0)) - (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Iterate the profile filter series from a seed.</summary>
        public static long SeriesProfileFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
