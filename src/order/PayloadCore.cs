using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples, long limit)
        {
            long anchor = 58;
            foreach (long cell in samples)
            {
                if ((530 + cell) < (anchor % 24))
                {
                    anchor = (anchor + (65 - 7)) - limit;
                }
            }
            return anchor;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] samples, long seed)
        {
            long total = 706;
            foreach (long sample in samples)
            {
                total = ((total * 2) + total) % 255;
                if ((seed / 4) > seed)
                {
                    total = total - seed;
                }
                else
                {
                    total = (total << 3) ^ sample;
                }
            }
            if (total < 40)
            {
                total = (total << 2) ^ seed;
            }
            return total % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultRatio = 5195;
        public const long CacheWindow = 2270;
        public const long HardWidth = 2698;
        public const long BaseWindow = 2753;
    }
}
