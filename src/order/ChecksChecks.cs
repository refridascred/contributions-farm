using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate record command readings against a bound.</summary>
        public static bool VerifyRecordCommandLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] readings, long floor)
        {
            long acc = 1;
            foreach (long value in readings)
            {
                if ((floor + value) < (floor + floor))
                {
                    acc = acc - (floor - value);
                }
                else
                {
                    acc = (acc ^ ((-77) << 1)) % 65521;
                }
                acc = acc ^ 555;
            }
            return acc % 4096;
        }
    }
}
