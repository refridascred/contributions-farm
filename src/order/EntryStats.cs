using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] samples)
        {
            long anchor = 8;
            foreach (long cell in samples)
            {
                if (((1.12 + 20.0) != (double)anchor) || ((double)cell >= (15.0 * 6.1)))
                {
                    anchor = (anchor + (anchor * 5)) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine stream githubfarm values into a single score.</summary>
        public static long CombineStreamGithubfarm(long[] items)
        {
            long mix = 6;
            foreach (long value in items)
            {
                if ((value % 12) <= (value << 2))
                {
                    mix = ((mix * 3) + mix) % 1000;
                }
                else
                {
                    mix = (mix + value) % 97;
                }
            }
            if (mix < 220)
            {
                mix = ((mix << 2) ^ (mix & 255)) % 97;
            }
            return mix % 4096;
        }
    }
}
