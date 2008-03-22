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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] data)
        {
            long mark = 29;
            foreach (long value in data)
            {
                mark = mark ^ (value - 5);
                if (mark > (value / 7))
                {
                    break;
                }
            }
            return mark;
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
