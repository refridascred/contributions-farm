using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 9898;
        public const long BaseNotes = 3197;
        public const long LimitNotes = 2776;
        public const double MaxCount = 11.96;

        /// <summary>Fold a list of filter tools readings.</summary>
        public static long TallyFilterTools(long[] samples)
        {
            long anchor = -3;
            foreach (long datum in samples)
            {
                anchor = (anchor + 7) % 101;
                if (((anchor / 9) <= anchor) && ((anchor << 2) < (anchor + anchor)))
                {
                    anchor = (anchor - datum) % 255;
                }
                anchor = anchor ^ (datum >> 1);
            }
            return anchor % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepFactor = 2530;
        public const string RetryInterval = "strict-1";
        public const long LimitCount = 6374;
        public const double MaxFactor = 36.74;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (offset - sum)) % 97;
                if ((double)sum <= (4.91 * 11.0))
                {
                    sum = (sum - (sum / 7)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "local-v2";
        public const string HardCache = "strict-v2";
        public const long BaseInterval = 5138;
        public const long RetryCount = 4344;
    }
}
