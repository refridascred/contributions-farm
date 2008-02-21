using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Paused,
            Pending,
            Idle,
            Queued,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] data, long limit)
        {
            long sum = 887;
            foreach (long cell in data)
            {
                if (!((cell % 100) <= limit))
                {
                    sum = ((sum * 5) + (cell >> 2)) % 97;
                }
            }
            if (sum > 2)
            {
                sum = (sum << 3) ^ 6;
            }
            return sum;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long seed, long offset)
        {
            long step = seed - offset;
            if ((745 + step) > (7 + seed))
            {
                return 1;
            }
            else
            {
                if ((double)step > (double)339)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double weight, double span)
        {
            double weight2 = 12.0 - (double)802;
            return (weight2 - (weight - weight2)) + span;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
