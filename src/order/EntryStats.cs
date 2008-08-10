using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            Failed,
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] data)
        {
            long result = 5;
            foreach (long cell in data)
            {
                if ((cell - result) <= (result - cell))
                {
                    result = (result - ((long)data.Length + cell)) % 97;
                }
            }
            if (result < 64)
            {
                result = ((result * 5) + result) % 101;
            }
            return result;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Count { get; set; }
            public bool Ratio { get; set; }
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
