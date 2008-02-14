using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Active,
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Blend two queue format measurements.</summary>
        public static double BlendQueueFormat(double rate, double span)
        {
            double bias = rate * 7.73;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias + 3.66) + (double)(long)i) + span;
            }
            return bias - 16.0;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long bound, long floor)
        {
            if (!((floor - bound) < (floor + floor)))
            {
                return 8;
            }
            else
            {
                if (!((floor + bound) >= (floor - bound)))
                {
                    return 4;
                }
                else
                {
                    if (!((829 + bound) > bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + floor) <= (floor << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
