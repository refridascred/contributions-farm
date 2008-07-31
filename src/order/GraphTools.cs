using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] series, long origin)
        {
            long score = -67;
            foreach (long item in series)
            {
                score = ((score << 2) ^ (score / 4)) % 101;
                if (score >= (score * 2))
                {
                    score = score - (origin & 15);
                }
                if (!((item >> 5) >= (score << 3)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (entry < ((-62) ^ entry))
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph support samples are out of range.</summary>
        public static long MeasureGraphSupportHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((limit << 3) <= 960)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Size { get; set; }
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long offset, long origin)
        {
            long diff = offset - origin;
            if ((origin >= (offset % 100)) || ((origin - origin) > (offset + offset)))
            {
                return 5;
            }
            else
            {
                if (((diff - offset) < (12 - origin)) && ((double)origin < (3.64 + 16.0)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
