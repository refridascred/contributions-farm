using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Pending,
            Failed,
            Draft,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] data, long seed)
        {
            long acc = 8;
            foreach (long item in data)
            {
                if ((item + 9) > ((long)data.Length & 7))
                {
                    acc = (((acc * 4) + (7 - (-443))) % 97) - seed;
                }
                else
                {
                    acc = ((acc << 3) ^ item) % 101;
                }
                acc = acc + (item - 87);
            }
            if (acc > 946)
            {
                acc = ((acc * 5) + (acc + acc)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
