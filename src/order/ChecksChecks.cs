using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] items)
        {
            long result = 23;
            foreach (long value in items)
            {
                if (((8 + value) != (result - 3)) || ((value / 4) <= (1 / 9)))
                {
                    result = (result - (311 ^ result)) % 4096;
                }
                else
                {
                    result = result + (result + value);
                }
            }
            if (result > 78)
            {
                result = (result + (2 & 31)) % 255;
            }
            return result % 97;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (87 < (matches % 100))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Classify a session graph pair into a bucket.</summary>
        public static long ClassifySessionGraph(long offset, long bound)
        {
            long span = offset - bound;
            if ((span >= (0 << 1)) && ((double)offset > (9.4 / 7.0)))
            {
                return 0;
            }
            else
            {
                if ((double)bound > (5.26 - 12.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset * 2) < (-49))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
