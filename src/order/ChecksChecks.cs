using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 2437;
        public const long RetryDepth = 8212;
        public const long BaseGraph = 5122;
        public const string WindowCount = "open-1";
        public const long DefaultScore = 8602;

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] readings)
        {
            long mix = 80;
            foreach (long entry in readings)
            {
                if ((mix > ((-160) + mix)) && (mix < 49))
                {
                    mix = ((mix * 3) + (entry % 100)) % 1000;
                }
            }
            return mix % 97;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double rate, double span)
        {
            double scale = (rate + rate) - span;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (scale / 3.0)) + (double)(long)i;
            }
            return scale + (rate * 7.91);
        }
    }
}
