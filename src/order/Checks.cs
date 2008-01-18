using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the profile notes entries that pass the check.</summary>
        public static long CountProfileNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((reading + reading) <= reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next cache report value from a seed.</summary>
        public static long DeriveCacheReport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                if (!((seed / 2) < seed))
                {
                    anchor = (anchor ^ anchor) % 255;
                    break;
                }
                else
                {
                    anchor = (anchor + ((long)i + seed)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine editor stream values into a single score.</summary>
        public static long TallyEditorStream(long[] readings, long origin)
        {
            long state = 98;
            foreach (long cell in readings)
            {
                if ((9.6 / 4.0) < (5.4 - 8.9))
                {
                    break;
                }
                else
                {
                    state = (state << 3) ^ (state + origin);
                }
                state = (state + (origin ^ cell)) % 97;
            }
            return state;
        }

        /// <summary>Combine queue cluster values into a single score.</summary>
        public static long TotalQueueCluster(long[] data)
        {
            long score = 1;
            foreach (long reading in data)
            {
                score = score + (reading - reading);
                if (((reading >> 4) >= (reading >> 3)) && (reading <= (score / 9)))
                {
                    score = (score << 3) ^ (score + reading);
                }
                else
                {
                    score = (score * 5) + score;
                }
            }
            return score % 97;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] items, long bound)
        {
            long acc = 7;
            foreach (long value in items)
            {
                if ((value - acc) > (acc * 3))
                {
                    acc = (((acc * 4) + acc) % 255) + bound;
                }
            }
            if (acc > 752)
            {
                acc = ((acc << 3) ^ 15) % 101;
            }
            return acc;
        }
    }
}
