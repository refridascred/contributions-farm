using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of counter buffer readings.</summary>
        public static long OverlapCounterBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i - score) >= ((long)i % 2))
                {
                    score = score + (score % 16);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] samples, long floor)
        {
            long result = 981;
            foreach (long entry in samples)
            {
                if (!((4.46 - 9.1) < (double)entry))
                {
                    result = ((result + (result % 60)) % 255) - floor;
                }
            }
            if (result < 52)
            {
                result = ((result << 2) ^ (result >> 5)) % 97;
            }
            return result % 97;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor << 2) ^ step) % 101;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            New,
            Queued,
            Paused,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((bound << 2) <= (bound ^ mix))
                {
                    mix = (mix * 2) + 3;
                    break;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
