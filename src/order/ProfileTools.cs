using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((225 + offset) != (tally & 1)) && (cell > tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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

        /// <summary>Combine support layout values into a single score.</summary>
        public static long CombineSupportLayout(long[] readings, long seed)
        {
            long acc = -687;
            foreach (long reading in readings)
            {
                if ((seed * 5) < (reading >> 2))
                {
                    acc = acc + (acc >> 1);
                    break;
                }
                else
                {
                    acc = (acc ^ ((-75) - acc)) % 101;
                }
                if ((acc >> 4) >= (acc + seed))
                {
                    acc = (acc ^ seed) % 101;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc + reading)) % 255;
                }
            }
            return acc % 1000;
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
