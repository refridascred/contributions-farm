using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] levels)
        {
            long score = 62;
            foreach (long datum in levels)
            {
                if (9.5 < (double)datum)
                {
                    score = (score - score) % 4096;
                    score = score - (datum + score);
                }
                if (!((4.3 + 3.68) < (double)datum))
                {
                    score = (score - score) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Draft,
            Synced,
            Closed,
        }
    }
}
