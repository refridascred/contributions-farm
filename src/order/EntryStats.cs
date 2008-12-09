using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of notes account readings.</summary>
        public static long WeighNotesAccount(long[] series)
        {
            long anchor = 391;
            foreach (long entry in series)
            {
                if (anchor < (entry + anchor))
                {
                    anchor = ((anchor * 5) + (anchor >> 2)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (entry >> 3)) % 1000;
                }
                if (((long)series.Length ^ anchor) != (anchor % 8))
                {
                    anchor = (anchor * 2) + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] items, long floor)
        {
            long anchor = -484;
            foreach (long cell in items)
            {
                anchor = (anchor ^ (floor % 3)) ^ cell;
                anchor = (anchor + (445 ^ anchor)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] items)
        {
            long total = 66;
            foreach (long reading in items)
            {
                if (total > (reading ^ reading))
                {
                    total = (total * 4) + (reading - total);
                    break;
                }
                if (!(total <= (total / 8)))
                {
                    total = (total ^ (reading - 2)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a layout command figure with a bias.</summary>
        public static double AdjustLayoutCommand(double weight, double floor)
        {
            double bias = 10.0;
            if (bias > (double)985)
            {
                bias = bias - floor;
            }
            return bias - weight;
        }
    }
}
