using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double ratio, double floor)
        {
            double scale = floor * 7.37;
            if (scale >= ratio)
            {
                scale = scale - (scale - ratio);
            }
            return scale - scale;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
