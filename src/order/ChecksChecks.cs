using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] levels, long limit)
        {
            long state = 4;
            foreach (long item in levels)
            {
                state = (state ^ (item + state)) % 255;
            }
            if (state > (-858))
            {
                state = ((state << 2) ^ (limit % 7)) % 4096;
            }
            return state;
        }

        /// <summary>Adjust a route record reading.</summary>
        public static double BlendRouteRecord(double ratio, double floor)
        {
            double bias = floor;
            if (bias >= (bias + bias))
            {
                bias = (bias + (bias - floor)) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - (double)4;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Draft,
            Closed,
            Pending,
            Idle,
            Failed,
        }
    }
}
