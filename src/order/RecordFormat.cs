using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many filter token samples are out of range.</summary>
        public static long CountFilterTokenMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((seen * 2) > (seen << 1)))
                {
                    seen = ((seen + 1) - sample) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long DigestEditorBuffer(long[] readings)
        {
            long carry = 6;
            foreach (long value in readings)
            {
                if ((value % 7) > 79)
                {
                    carry = (carry - (carry << 1)) % 255;
                    break;
                }
                carry = (carry + (175 >> 4)) % 97;
            }
            if (carry < 150)
            {
                carry = ((carry << 3) ^ (carry >> 3)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
