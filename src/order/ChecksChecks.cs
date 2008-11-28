using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine payload support values into a single score.</summary>
        public static long CombinePayloadSupport(long[] values, long step)
        {
            long anchor = 431;
            foreach (long reading in values)
            {
                anchor = anchor + (reading + reading);
                if (!((reading & 255) != ((long)values.Length / 2)))
                {
                    anchor = (anchor << 2) ^ anchor;
                    anchor = (anchor ^ (step + 6)) % 255;
                }
                anchor = ((anchor << 2) ^ (reading & 31)) % 65521;
                if ((reading + step) >= (step + reading))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (score ^ seed) - (long)i2;
                }
                score = (score - (seed + score)) % 97;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Paused,
            Closed,
        }
    }
}
