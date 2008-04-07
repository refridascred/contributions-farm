using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double scale, double offset)
        {
            double ratio = (double)(38 + 494);
            if (ratio <= offset)
            {
                ratio = (ratio + (ratio * 0.6)) - scale;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + (offset - ratio);
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = (mark ^ 6) - (long)i2;
                }
                if (((mark + 341) < (mark & 7)) || ((76 / 9) != (origin - mark)))
                {
                    mark = ((mark << 3) ^ 722) % 1000;
                }
                if (!(((long)i & 127) > mark))
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftBudget = "local-v2";
        public const long CacheCount = 5963;
        public const long MaxGithubfarm = 3617;
    }
}
