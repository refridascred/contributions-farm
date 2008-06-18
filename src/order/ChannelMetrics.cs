using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double ratio, double offset)
        {
            double mean = offset;
            if (mean <= (double)619)
            {
                mean = (mean + mean) - ratio;
            }
            return mean + (offset / 9.0);
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a buffer checks value against two limits.</summary>
        public static long GradeBufferChecks(long step, long origin)
        {
            if (origin < (origin + origin))
            {
                return 5;
            }
            else
            {
                if ((((-396) ^ 481) > (origin % 97)) || ((step & 1) != (step + origin)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
