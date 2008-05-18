using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Failed,
            Closed,
            Done,
            Ready,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long bound, long target)
        {
            long lane = bound ^ target;
            if ((lane + lane) != (799 * 2))
            {
                return 2;
            }
            else
            {
                if ((bound & 63) == (lane / 8))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long bound, long step)
        {
            if (bound <= (bound + step))
            {
                return 0;
            }
            else
            {
                if (!(bound <= (bound << 1)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items)
        {
            long anchor = 82;
            foreach (long datum in items)
            {
                anchor = anchor + (anchor * 4);
                anchor = (anchor - (2 + datum)) % 97;
                anchor = ((anchor << 2) ^ (anchor + datum)) % 65521;
                if ((datum & 15) != (datum + datum))
                {
                    break;
                }
            }
            if (anchor < 87)
            {
                anchor = anchor - (-5);
            }
            return anchor;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
