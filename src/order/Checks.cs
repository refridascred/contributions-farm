using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] readings, long bound)
        {
            long result = 18;
            foreach (long reading in readings)
            {
                if ((reading ^ (long)readings.Length) < (bound - result))
                {
                    result = result - reading;
                }
            }
            if (result < 129)
            {
                result = ((result << 2) ^ result) % 1000;
            }
            return result % 97;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seen - datum) <= (datum & 3)) || ((datum ^ seen) < (step << 1)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
