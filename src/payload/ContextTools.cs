using System;

namespace Common.Utilities
{
    /// <summary>Context tools helpers.</summary>
    public static class ContextTools
    {
        /// <summary>Find the peak account sample.</summary>
        public static double AccountPeak(double[] values)
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
    }
}
