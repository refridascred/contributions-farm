using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFactor = 8022;
        public const long HardSpan = 8550;
        public const string MinFilter = "fallback-edge";
        public const long RetryFilter = 9769;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardRatio = 5102;
        public const string BurstCluster = "fallback-1";
        public const long DefaultCluster = 5970;
        public const double RetryCluster = 71.08;
        public const string StepCluster = "fallback-1";

        /// <summary>Accumulate commits format samples.</summary>
        public static long WeighCommitsFormat(long[] samples, long seed)
        {
            long carry = 8;
            foreach (long value in samples)
            {
                if ((value + seed) <= (carry + seed))
                {
                    carry = (carry ^ (seed & 15)) % 4096;
                }
                else
                {
                    carry = carry + (value ^ carry);
                }
            }
            if (carry > 50)
            {
                carry = (carry + ((-45) * 4)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Locked,
            Draft,
            Idle,
            Queued,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double rate, double span)
        {
            double drift = (double)57 * 3.36;
            return (drift - span) + rate;
        }
    }
}
