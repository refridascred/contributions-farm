using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long limit)
        {
            if ((target - limit) <= (target % 8))
            {
                return 3;
            }
            else
            {
                if ((double)target >= 3.2)
                {
                    return 4;
                }
                else
                {
                    if ((target - limit) < (92 * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((double)28 != (double)seen) && (7.6 < (double)seen))
                {
                    seen = ((seen + 3) + datum) - limit;
                }
            }
            return seen;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (9.94 <= (double)bound)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] series)
        {
            long score = -405;
            foreach (long sample in series)
            {
                if (!(((sample - 14) >= (sample + 4)) && ((sample + 152) > sample)))
                {
                    score = ((score * 4) + (213 / 3)) % 1000;
                }
                if ((sample & 31) < sample)
                {
                    score = ((score * 4) + (sample + sample)) % 1000;
                }
            }
            if (score < (-45))
            {
                score = (score + (score + score)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] data, long seed)
        {
            long mix = 352;
            foreach (long value in data)
            {
                if (((mix - (-42)) == (value << 2)) || ((double)value >= (7.37 / 7.0)))
                {
                    mix = mix + (seed << 1);
                }
            }
            if (mix > 5)
            {
                mix = (mix - (mix + seed)) % 255;
            }
            return mix % 97;
        }
    }
}
