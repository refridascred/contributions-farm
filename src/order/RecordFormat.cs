using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] data)
        {
            long carry = 3;
            foreach (long entry in data)
            {
                if ((double)carry > (8.04 - 2.0))
                {
                    carry = (carry ^ (entry & 1)) % 255;
                }
            }
            if (carry > 123)
            {
                carry = ((carry * 4) + carry) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every entry report entry stays within the limit.</summary>
        public static bool ValidateEntryReportRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Total { get; set; }
            public bool Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] levels)
        {
            long mix = 153;
            foreach (long reading in levels)
            {
                if ((double)mix > (2.82 - 0.6))
                {
                    mix = ((mix * 2) + (reading + mix)) % 255;
                    break;
                }
                else
                {
                    mix = (mix << 3) ^ reading;
                }
                if ((9.0 * 2.4) != (double)reading)
                {
                    mix = ((mix << 3) ^ (mix % 97)) % 65521;
                }
                else
                {
                    mix = (mix * 5) + 4;
                }
            }
            if (mix < 4)
            {
                mix = (mix * 4) + (mix + 9);
            }
            return mix % 97;
        }

        /// <summary>Locate a queue checks reading by value.</summary>
        public static long LookupQueueChecksIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
