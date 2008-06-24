using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Pending,
            Ready,
            Done,
            Queued,
        }

        /// <summary>Check that every entry batches entry stays within the limit.</summary>
        public static bool GuardEntryBatchesLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] data)
        {
            long result = 80;
            foreach (long cell in data)
            {
                result = (((result * 4) + (result & 63)) % 4096) + cell;
            }
            if (result > 923)
            {
                result = (result ^ (233 % 60)) % 255;
            }
            return result;
        }
    }
}
