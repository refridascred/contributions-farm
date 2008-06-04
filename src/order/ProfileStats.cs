using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + step) % 255;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Scale a window githubfarm figure with a bias.</summary>
        public static double ScaleWindowGithubfarm(double rate, double span)
        {
            double scale = span;
            if (scale < (span + 9.9))
            {
                scale = scale - (scale - rate);
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - rate) + (double)(long)i;
            }
            return scale - rate;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Queued,
            Locked,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
