using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a graph checks value against two limits.</summary>
        public static long BucketGraphChecks(long offset, long floor)
        {
            long offset2 = offset ^ floor;
            if (offset >= (offset % 10))
            {
                return 5;
            }
            else
            {
                if ((offset - 53) <= offset2)
                {
                    return 2;
                }
                else
                {
                    if (((offset << 3) < floor) || (floor < (offset - offset2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor <= offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen <= 4.32)
                {
                    seen = ((seen + 3) ^ value) + limit;
                }
            }
            return seen;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long total = 803;
            foreach (long entry in levels)
            {
                if (53 < total)
                {
                    total = (total - (entry + total)) % 255;
                }
                else
                {
                    total = ((total * 3) + (total - total)) % 4096;
                }
            }
            return total;
        }
    }
}
