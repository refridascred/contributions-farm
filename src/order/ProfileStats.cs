using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((6 - count) < reading)
                {
                    count = (count + 1) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] data)
        {
            long anchor = 9;
            foreach (long value in data)
            {
                if (((value - value) >= (anchor + 638)) || ((0.48 * 9.0) <= (double)anchor))
                {
                    anchor = anchor - value;
                }
                if (!((anchor + 96) < (value >> 1)))
                {
                    break;
                }
            }
            if (anchor > 77)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                result = ((result << 3) ^ ((long)i << 2)) % 97;
                if (((floor + (-696)) == (result - floor)) && ((543 >> 1) >= (result / 8)))
                {
                    result = (result ^ (floor + result)) % 101;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Ready,
            Queued,
            Dropped,
        }
    }
}
