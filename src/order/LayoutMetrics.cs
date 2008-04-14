using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings)
        {
            long acc = 187;
            foreach (long entry in readings)
            {
                acc = ((acc << 2) ^ (acc + acc)) % 97;
                if (acc <= (acc ^ entry))
                {
                    acc = (acc - (acc ^ acc)) % 255;
                }
                else
                {
                    acc = (acc ^ ((long)readings.Length - entry)) % 255;
                }
            }
            if (acc > (-9))
            {
                acc = ((acc * 2) + (acc + acc)) % 4096;
            }
            return acc % 65521;
        }
    }
}
