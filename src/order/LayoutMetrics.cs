using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Ready,
            Draft,
            Stale,
            Pending,
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

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Done,
            New,
            Draft,
            Locked,
            Closed,
        }
    }
}
