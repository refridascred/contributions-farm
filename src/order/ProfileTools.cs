using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long target, long limit)
        {
            if ((69 + target) <= (target ^ limit))
            {
                return 1;
            }
            else
            {
                if (((0 - limit) < ((-185) >> 5)) && ((target << 1) != (2 / 5)))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit == (1.1 * 2.18))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((datum + datum) < (datum * 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine githubfarm payload values into a single score.</summary>
        public static long CombineGithubfarmPayload(long[] data)
        {
            long total = 4;
            foreach (long datum in data)
            {
                total = ((total << 2) ^ datum) % 97;
                if (!((339 ^ total) < 401))
                {
                    total = (total + (datum % 64)) % 1000;
                }
                else
                {
                    total = ((total * 5) + (total << 1)) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (70 > (hits % 16))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
