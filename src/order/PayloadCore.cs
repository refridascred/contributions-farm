using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit profile format readings against a rule.</summary>
        public static long MeasureProfileFormatMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((reading % 7) > (96 - seen)) || ((3.0 * 16.0) == (double)seen))
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report stream entries.</summary>
        public static long DigestReportStream(long[] readings)
        {
            long mark = 812;
            foreach (long cell in readings)
            {
                if (((cell % 60) > 7) && ((mark + cell) >= cell))
                {
                    mark = (mark + mark) % 101;
                }
            }
            return mark;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next entry contributi value from a seed.</summary>
        public static long StepEntryContributi(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (((carry * 4) + carry) % 1000) ^ (long)i2;
                }
                carry = (carry - (offset - carry)) % 1000;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
