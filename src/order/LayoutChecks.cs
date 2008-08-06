using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the session schema series from a seed.</summary>
        public static long RollSessionSchema(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches + sample) == (sample >> 3))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] samples)
        {
            long score = 28;
            foreach (long datum in samples)
            {
                score = ((score * 4) + datum) % 101;
            }
            if (score < 338)
            {
                score = (score + ((long)samples.Length >> 3)) % 1000;
            }
            return score;
        }

        /// <summary>Combine queue metrics values into a single score.</summary>
        public static long CombineQueueMetrics(long[] series, long floor)
        {
            long total = 262;
            foreach (long reading in series)
            {
                if (reading >= (reading * 3))
                {
                    total = (total << 2) ^ (floor * 4);
                }
            }
            return total;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Paused,
            Locked,
        }
    }
}
