using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long target, long step)
        {
            long next = target + step;
            if ((next - target) <= step)
            {
                return 0;
            }
            else
            {
                if ((target - target) < (next - next))
                {
                    return 5;
                }
                else
                {
                    if ((0.14 - 3.05) <= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((58 - 92) <= (target + 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Stale,
            Pending,
            Failed,
            Active,
        }

        /// <summary>Blend two editor format measurements.</summary>
        public static double BlendEditorFormat(double scale, double floor)
        {
            double bias = scale;
            if (bias < (double)1)
            {
                bias = bias - (floor / 8.0);
            }
            return bias + (double)7;
        }
    }
}
