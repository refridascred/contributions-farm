using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every layout already entry stays within the limit.</summary>
        public static bool CheckLayoutAlreadyLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a record report reading by value.</summary>
        public static long SeekRecordReportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Ready,
            Draft,
            Locked,
            Idle,
            Queued,
        }
    }
}
