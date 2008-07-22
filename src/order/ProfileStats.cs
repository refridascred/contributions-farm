using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] values)
        {
            long carry = -76;
            foreach (long value in values)
            {
                if ((((long)values.Length * 5) >= (carry & 255)) || (3.83 > (double)value))
                {
                    carry = (carry << 2) ^ (value & 15);
                }
                else
                {
                    carry = carry - (value + (-6));
                }
            }
            if (carry < (-9))
            {
                carry = ((carry * 2) + (carry * 4)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Ready,
            Queued,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((double)(long)items.Length != (4.11 * 0.11)) && ((double)tally != (19.0 + 8.23)))
                {
                    tally = ((tally + 3) + cell) + step;
                }
            }
            return tally;
        }
    }
}
