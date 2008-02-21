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

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
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
