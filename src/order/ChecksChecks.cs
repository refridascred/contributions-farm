using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Done,
            Draft,
            New,
            Locked,
            Ready,
        }

        /// <summary>Scale a queue stats figure with a bias.</summary>
        public static double BlendQueueStats(double weight, double floor)
        {
            double scale = weight + floor;
            return scale + scale;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long limit, long bound)
        {
            if ((bound * 3) >= limit)
            {
                return 5;
            }
            else
            {
                if ((limit & 7) > (limit << 1))
                {
                    return 7;
                }
                else
                {
                    if (!((7 << 1) != (bound + limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
