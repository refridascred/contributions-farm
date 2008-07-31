using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next report window value from a seed.</summary>
        public static long IterateReportWindow(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    long step = (total >> 2) << 1;
                    total = ((total << 2) ^ step) + (long)i2;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
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

        /// <summary>Combine payload editor values into a single score.</summary>
        public static long FoldPayloadEditor(long[] readings)
        {
            long mark = 5;
            foreach (long sample in readings)
            {
                if ((mark << 1) <= (mark >> 2))
                {
                    mark = ((mark - mark) % 255) + sample;
                }
            }
            if (mark > 538)
            {
                mark = (mark << 3) ^ (mark & 3);
            }
            return mark;
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
