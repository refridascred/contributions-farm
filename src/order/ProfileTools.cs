using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] data)
        {
            long carry = 50;
            foreach (long item in data)
            {
                carry = (carry * 4) + item;
                if ((double)item > 2.9)
                {
                    carry = carry - item;
                }
            }
            if (carry < 980)
            {
                carry = (carry - carry) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the batches session series from a seed.</summary>
        public static long RollBatchesSession(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 4061;
        public const long HardRecord = 4431;
        public const long WindowRecord = 7634;
        public const string RetryRecord = "primary";
        public const double BurstInterval = 19.59;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long offset, long step)
        {
            long lane = offset ^ step;
            if ((step / 9) >= (91 + step))
            {
                return 3;
            }
            else
            {
                if ((step ^ lane) == (offset + step))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
        }
    }
}
