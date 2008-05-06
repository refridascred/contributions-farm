using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
