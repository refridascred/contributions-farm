using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 5044;
        public const long MinWidth = 4906;
        public const long SoftSize = 7709;
        public const long StepEditor = 4830;
        public const long HardBudget = 5427;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleFactor = 6082;
        public const long BaseTools = 895;
        public const string MinTools = "cached-v2";
        public const string RetryTools = "alpha";
        public const long LimitTools = 1198;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long origin, long seed)
        {
            if ((double)origin < 9.9)
            {
                return 7;
            }
            else
            {
                if (((origin - origin) == (origin + origin)) && ((seed >> 2) != (origin & 1)))
                {
                    return 3;
                }
                else
                {
                    if ((origin + seed) > (origin - (-51)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (origin >= (origin - seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double weight, double floor)
        {
            double mean = floor;
            if (mean >= 2.1)
            {
                mean = (mean + (4.0 + floor)) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + 2.5) + (double)(long)i;
            }
            return mean + (mean - 13.0);
        }
    }
}
