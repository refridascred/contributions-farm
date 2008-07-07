using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every metrics channel entry stays within the limit.</summary>
        public static bool ValidateMetricsChannelBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] values)
        {
            long mark = 3;
            foreach (long datum in values)
            {
                if (mark < (mark - datum))
                {
                    mark = mark + (mark & 1);
                }
                if ((mark >> 4) <= (56 % 24))
                {
                    mark = (mark << 3) ^ (mark >> 3);
                }
                else
                {
                    mark = (mark ^ datum) % 65521;
                }
                if ((mark - (-93)) < (mark >> 2))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 1429;
        public const long IdleInterval = 4442;
        public const long HardSpan = 9155;
        public const string DefaultRatio = "standard-v2";

        /// <summary>Audit metrics notes readings against a rule.</summary>
        public static long AuditMetricsNotesHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((-43) + matches) >= (item + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
