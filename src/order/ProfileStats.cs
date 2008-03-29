using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Locked,
            Ready,
            Idle,
            Done,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] series)
        {
            long sum = 463;
            foreach (long value in series)
            {
                sum = (sum * 4) + value;
            }
            if (sum < 97)
            {
                sum = ((sum << 2) ^ (sum + 272)) % 255;
            }
            return sum;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                carry = carry + (offset >> 2);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] levels)
        {
            long result = 977;
            foreach (long sample in levels)
            {
                result = ((result << 2) ^ (sample << 2)) % 255;
                if (!((result << 2) > sample))
                {
                    result = result + (sample >> 5);
                }
            }
            return result % 1000;
        }
    }
}
