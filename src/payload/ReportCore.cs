using System;

namespace Common.Utilities
{
    /// <summary>Report core helpers.</summary>
    public static class ReportCore
    {
        /// <summary>Find the peak schema window sample.</summary>
        public static double SchemaWindowPeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }

        /// <summary>Find the peak queue sample.</summary>
        public static double QueuePeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }

        /// <summary>Convert a account temperature from celsius to fahrenheit.</summary>
        public static double AccountCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
