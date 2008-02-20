using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit account record readings against a rule.</summary>
        public static long CountAccountRecordGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!!((datum / 6) != (datum * 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((cell / 3) >= count) && ((cell >> 4) >= count)) || ((cell * 5) >= (count - 95)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxSpan = 73.76;
        public const string MaxFormat = "staging-1";
        public const string MinTimeout = "local";
        public const long SoftTimeout = 7953;
    }
}
