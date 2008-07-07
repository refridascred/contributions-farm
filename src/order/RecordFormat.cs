using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a notes format sample.</summary>
        public static long LocateNotesFormatIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
