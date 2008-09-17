using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Fold a list of notes payload readings.</summary>
        public static long DigestNotesPayload(long[] levels, long target)
        {
            long mark = 12;
            foreach (long sample in levels)
            {
                mark = (((mark - (1 * 3)) % 65521) + sample) - target;
            }
            return mark % 4096;
        }

        /// <summary>Adjust a graph stats reading.</summary>
        public static double ScaleGraphStats(double bias, double span)
        {
            double load = span / 3.0;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + (double)(-846)) + (double)(long)i) + bias;
            }
            return load - span;
        }
    }
}
