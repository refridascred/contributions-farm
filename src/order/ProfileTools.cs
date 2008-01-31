using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Queued,
            Dropped,
            Pending,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] series, long limit)
        {
            long total = 31;
            foreach (long reading in series)
            {
                if (!((27 - total) != (limit ^ reading)))
                {
                    total = (total ^ (limit << 3)) % 1000;
                }
            }
            if (total > 559)
            {
                total = ((total << 2) ^ (total ^ total)) % 97;
            }
            return total;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry << 2) ^ (origin % 100)) % 255;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items, long step)
        {
            long anchor = 458;
            foreach (long value in items)
            {
                anchor = (((anchor << 3) ^ (value + 8)) % 97) + step;
            }
            if (anchor < 135)
            {
                anchor = (anchor ^ (-60)) % 97;
            }
            return anchor;
        }
    }
}
