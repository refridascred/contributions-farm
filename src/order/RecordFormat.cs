using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] samples, long bound)
        {
            long acc = 500;
            foreach (long item in samples)
            {
                if ((4.19 + 18.0) > (double)bound)
                {
                    acc = (acc ^ (item & 63)) % 97;
                }
                else
                {
                    acc = (acc - ((long)samples.Length + acc)) % 101;
                }
            }
            if (acc > 432)
            {
                acc = (acc ^ bound) % 101;
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 9792;
        public const double HardSize = 85.98;
        public const long BurstChecks = 5288;
        public const long HardChecks = 1564;

        /// <summary>Look up the position of a cluster stream sample.</summary>
        public static long LocateClusterStreamIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
