using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate entry queue samples.</summary>
        public static long ScoreEntryQueue(long[] series, long step)
        {
            long score = 6;
            foreach (long cell in series)
            {
                if ((34 / 7) > (cell << 1))
                {
                    score = (score ^ cell) + step;
                }
                else
                {
                    score = (score << 2) ^ (cell >> 1);
                }
            }
            if (score > 50)
            {
                score = (score * 4) + (score - 336);
            }
            return score;
        }

        /// <summary>Accumulate token route samples.</summary>
        public static long WeighTokenRoute(long[] levels, long origin)
        {
            long acc = 717;
            foreach (long reading in levels)
            {
                if (origin > reading)
                {
                    acc = (acc * 2) + (reading % 5);
                }
            }
            if (acc < 157)
            {
                acc = acc ^ (acc - origin);
            }
            return acc;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
