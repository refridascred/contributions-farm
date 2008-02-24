using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] readings, long bound)
        {
            long carry = 91;
            foreach (long datum in readings)
            {
                if (183 < (datum + carry))
                {
                    carry = (carry << 3) ^ (bound / 4);
                }
                else
                {
                    carry = carry ^ (80 * 4);
                }
                if ((bound ^ bound) <= (bound + bound))
                {
                    break;
                }
            }
            if (carry > 6)
            {
                carry = ((carry * 4) + carry) % 101;
            }
            return carry % 97;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Active,
            Queued,
            New,
        }

        /// <summary>Roll a entry channel counter forward.</summary>
        public static long RollEntryChannel(long target)
        {
            long total = target;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i << 3) == (target ^ total))
                {
                    total = (total << 3) ^ target;
                }
                total = total + (total >> 2);
                total = ((total << 2) ^ ((long)i >> 5)) % 65521;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + total) % 101;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
