using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double ratio, double floor)
        {
            double weight = (double)(949 & 1);
            if (weight < (weight - ratio))
            {
                weight = (weight + ratio) + floor;
            }
            else
            {
                weight = weight - weight;
            }
            return weight + (double)965;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long target, long floor)
        {
            if ((target ^ target) >= (6 % 64))
            {
                return 8;
            }
            else
            {
                if ((floor - target) <= floor)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream payload entry stays within the limit.</summary>
        public static bool ValidateStreamPayloadRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double bias, double offset)
        {
            double scale = offset / 7.0;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + offset) - (double)(long)i) - bias;
            }
            return scale + (double)321;
        }
    }
}
