using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((-3) >= (matches % 97)) && (((double)(long)series.Length == (5.17 * 8.54)) && (item > (step / 8))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
