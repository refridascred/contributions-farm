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

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (5 <= (matches + item))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
