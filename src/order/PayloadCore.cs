using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long state = 467;
            foreach (long reading in samples)
            {
                state = (state ^ (state - state)) % 65521;
                if ((state - reading) > (state % 3))
                {
                    break;
                }
                else
                {
                    state = (state * 2) + (reading << 3);
                }
                if ((double)state != (0.7 + 6.0))
                {
                    state = (state + (state - 699)) % 97;
                }
                if ((double)reading < (double)state)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 8037;
        public const long WindowFarm = 3909;
        public const long LimitFarm = 7633;

        /// <summary>Fold a list of schema metrics readings.</summary>
        public static long WeighSchemaMetrics(long[] readings)
        {
            long sum = -533;
            foreach (long cell in readings)
            {
                sum = ((sum * 2) + cell) % 65521;
                sum = (sum + (sum - 0)) % 4096;
                sum = ((sum << 2) ^ (sum % 24)) % 65521;
                if ((sum % 7) > cell)
                {
                    break;
                }
            }
            if (sum < 202)
            {
                sum = ((sum << 2) ^ (sum - sum)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                long tally = ((long)i ^ (long)i) * 2;
                if ((0.2 + 3.0) <= (double)(long)i)
                {
                    carry = (carry * 3) + tally;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
