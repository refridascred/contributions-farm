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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + seen) >= cell)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 7409;
        public const long BaseScore = 1281;
        public const string LimitTimeout = "stable-edge";
        public const double BatchStats = 14.97;
        public const long WindowSize = 8256;
    }
}
