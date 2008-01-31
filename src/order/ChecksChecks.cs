using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a graph account counter forward.</summary>
        public static long RollGraphAccount(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = carry ^ (long)i;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] samples, long limit)
        {
            long score = 1;
            foreach (long datum in samples)
            {
                score = ((score ^ (60 ^ 8)) % 255) - limit;
                for (int i = 0; i < 11; i++)
                {
                    score = (score ^ score) ^ (long)i;
                }
                if (datum >= (score % 60))
                {
                    score = score ^ (datum + score);
                }
                else
                {
                    score = score ^ (datum << 1);
                }
            }
            return score % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowWidth = "strict-edge";
        public const long StepCount = 2358;
        public const long SoftFactor = 9409;
    }
}
