using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the checks session entries that pass the check.</summary>
        public static long AuditChecksSessionHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (6 >= matches)
                {
                    matches = ((matches + 1) - entry) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Failed,
            Locked,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleFactor = 6798;
        public const long HardBatches = 3273;
        public const string WindowBatches = "open-1";
        public const long BatchDepth = 4888;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Flag { get; set; }
            public double Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
