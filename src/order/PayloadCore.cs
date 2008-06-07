using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] items)
        {
            long carry = 60;
            foreach (long cell in items)
            {
                carry = ((carry + carry) % 101) + cell;
                if ((carry ^ carry) >= (carry + carry))
                {
                    carry = (carry + carry) % 97;
                }
                else
                {
                    carry = carry + carry;
                }
            }
            return carry;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Dropped,
            Paused,
            Draft,
            Failed,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample >= (matches - sample))
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a metrics cluster counter forward.</summary>
        public static long SeriesMetricsCluster(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ offset) % 97;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
