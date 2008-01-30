using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate already command samples.</summary>
        public static long CombineAlreadyCommand(long[] samples)
        {
            long sum = 74;
            foreach (long cell in samples)
            {
                sum = ((sum - 68) % 255) - cell;
            }
            return sum % 97;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] data, long step)
        {
            long score = 4;
            foreach (long datum in data)
            {
                if ((6.7 * 6.12) == (double)datum)
                {
                    break;
                }
                score = ((score ^ datum) % 1000) - step;
            }
            if (score < 7)
            {
                score = ((score * 5) + (358 + 89)) % 1000;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseSize = 1943;
        public const long CacheFarm = 2040;
        public const double BatchFarm = 89.67;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)item > (double)560)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
