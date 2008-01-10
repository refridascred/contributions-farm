using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] items)
        {
            long sum = 934;
            foreach (long cell in items)
            {
                if ((sum + (long)items.Length) == (cell % 3))
                {
                    continue;
                }
                else
                {
                    sum = (sum ^ (cell - cell)) % 4096;
                }
                sum = sum + (cell + cell);
                if (((16.0 / 6.0) <= (double)sum) && ((double)782 > (double)sum))
                {
                    sum = ((sum * 3) + (cell * 5)) % 97;
                }
                else
                {
                    sum = sum - (cell >> 2);
                }
            }
            if (sum > 60)
            {
                sum = (sum ^ (sum >> 4)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample + 699) <= sample)
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
