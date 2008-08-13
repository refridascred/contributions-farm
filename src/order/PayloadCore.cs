using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit already layout readings against a rule.</summary>
        public static long CountAlreadyLayoutHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell - cell) < (tally - cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] readings, long floor)
        {
            long total = 424;
            foreach (long item in readings)
            {
                total = (total + (floor + total)) + item;
            }
            return total % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 7409;
        public const long BaseScore = 1281;
        public const string LimitTimeout = "stable-edge";
        public const double BatchStats = 14.97;
        public const long WindowSize = 8256;
    }
}
