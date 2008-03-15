using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double bias, double offset)
        {
            double ratio = (double)(-613) + offset;
            if (ratio >= (offset - bias))
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio + (ratio + offset);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheAlready = "local";
        public const long MinRatio = 543;
        public const long BurstSpan = 380;
        public const long LimitAlready = 8972;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseStats = 75.77;
        public const long MinStats = 2009;
        public const long WindowStats = 3889;

        /// <summary>Iterate the editor notes series from a seed.</summary>
        public static long StepEditorNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                mark = mark - (target >> 1);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Dropped,
            Queued,
            Done,
        }
    }
}
