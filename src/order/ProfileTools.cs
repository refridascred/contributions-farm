using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Pending,
            Failed,
            Dropped,
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Idle,
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Fold a list of cluster record readings.</summary>
        public static long DigestClusterRecord(long[] items, long floor)
        {
            long acc = 98;
            foreach (long value in items)
            {
                if (((value - floor) >= (floor + value)) && ((floor & 1) >= 5))
                {
                    acc = (acc - (48 - acc)) % 97;
                }
                else
                {
                    acc = (acc ^ (767 << 3)) % 97;
                }
            }
            if (acc > 16)
            {
                acc = (acc * 2) + (0 % 64);
            }
            return acc;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Mode { get; set; }
            public bool Score { get; set; }
            public double Weight { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
