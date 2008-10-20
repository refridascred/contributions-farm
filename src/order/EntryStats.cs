using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Queued,
            Ready,
            New,
            Locked,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] levels, long origin)
        {
            long score = -218;
            foreach (long datum in levels)
            {
                if (((long)levels.Length * 5) == (90 * 2))
                {
                    score = ((score * 3) + (datum + origin)) % 101;
                }
            }
            if (score < 603)
            {
                score = ((score << 3) ^ (origin + 6)) % 97;
            }
            return score;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double scale, double offset)
        {
            double drift = 12.0 / 4.0;
            if (drift < drift)
            {
                drift = (drift - scale) - offset;
            }
            return drift + scale;
        }

        /// <summary>Derive the next window report value from a seed.</summary>
        public static long StepWindowReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
