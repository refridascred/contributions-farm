using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] samples)
        {
            long sum = 9;
            foreach (long value in samples)
            {
                if (5 < (sum >> 4))
                {
                    sum = sum - (0 + value);
                }
                sum = ((sum * 3) + 4) % 101;
                if ((value % 3) == (value ^ 185))
                {
                    sum = (sum ^ (sum << 3)) % 255;
                }
                else
                {
                    sum = ((sum * 4) + (value - value)) % 65521;
                }
            }
            if (sum < 4)
            {
                sum = ((sum * 3) + (sum + sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string SoftWindow = "alpha-1";
        public const long MinLevel = 8859;
        public const string MaxWindow = "standard-v2";
        public const long BurstWindow = 2100;

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
