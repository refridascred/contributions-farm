using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double gain, double floor)
        {
            double rate = (double)(220 >> 3);
            if (rate < (double)52)
            {
                rate = (rate + (rate * 8.0)) + floor;
            }
            else
            {
                rate = rate + (gain * 5.21);
            }
            return rate + (rate * 1.87);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftPayload = "cached-v2";
        public const long RetryPayload = 4357;
        public const long SoftSize = 222;
        public const long DefaultPayload = 7691;
        public const long BatchPayload = 9612;
    }
}
