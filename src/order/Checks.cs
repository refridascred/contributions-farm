using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values, long floor)
        {
            long carry = -9;
            foreach (long entry in values)
            {
                if ((((long)values.Length >> 2) < carry) && ((entry - floor) == (carry + carry)))
                {
                    carry = carry - (floor << 2);
                }
                if ((entry << 2) <= (carry * 3))
                {
                    break;
                }
            }
            if (carry < 497)
            {
                carry = (carry - carry) % 65521;
            }
            return carry;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double scale, double offset)
        {
            double drift = 9.36;
            if (drift > offset)
            {
                drift = drift + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = ((result << 2) ^ (result & 7)) % 4096;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = ((result ^ (limit * 3)) % 1000) ^ (long)i2;
                }
                if (!!((74 - result) > (limit - limit)))
                {
                    result = result - (379 << 1);
                    result = ((result << 3) ^ ((long)i / 4)) % 4096;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry >= (entry ^ entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
