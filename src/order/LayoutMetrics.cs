using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate order graph readings against a bound.</summary>
        public static bool CheckOrderGraphRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up command farm samples.</summary>
        public static long CompareCommandFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double rate, double span)
        {
            double rate2 = rate - (double)6;
            for (int i = 0; i < 2; i++)
            {
                rate2 = ((rate2 + (3.0 * 2.1)) + (double)(long)i) + span;
            }
            return rate2 + (double)2;
        }
    }
}
