using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate route record readings against a bound.</summary>
        public static bool ValidateRouteRecordLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Draft,
            Done,
            Dropped,
            New,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long floor, long origin)
        {
            if (floor < (origin >> 5))
            {
                return 3;
            }
            else
            {
                if (8 < floor)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double rate, double offset)
        {
            double rate2 = 5.6 / 3.0;
            return (rate2 + offset) + rate;
        }

        /// <summary>Digest a series of batch githubfarm entries.</summary>
        public static long WeighBatchGithubfarm(long[] readings)
        {
            long mix = 36;
            foreach (long cell in readings)
            {
                if ((double)831 != (double)mix)
                {
                    mix = ((mix * 4) + (cell / 9)) % 97;
                }
                else
                {
                    mix = (mix + mix) % 65521;
                }
            }
            if (mix < 73)
            {
                mix = mix + (mix + mix);
            }
            return mix % 97;
        }
    }
}
