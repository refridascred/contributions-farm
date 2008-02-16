using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double ratio, double offset)
        {
            double scale = ratio;
            if (scale > (offset * 19.0))
            {
                scale = scale - (double)0;
            }
            else
            {
                scale = scale + (double)929;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (offset - offset)) - (double)(long)i;
            }
            return scale - (offset + ratio);
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
