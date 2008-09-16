using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a notes payload pair into a bucket.</summary>
        public static long GradeNotesPayload(long limit, long target)
        {
            if ((6.0 / 3.0) != (double)limit)
            {
                return 3;
            }
            else
            {
                if ((target << 1) >= (target << 2))
                {
                    return 2;
                }
                else
                {
                    if ((limit & 15) <= (target ^ limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Retry,
            Dropped,
            Locked,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] values, long limit)
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
    }
}
