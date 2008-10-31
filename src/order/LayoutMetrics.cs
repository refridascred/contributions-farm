using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((seed ^ (-670)) <= (sample << 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] items)
        {
            long total = 40;
            foreach (long value in items)
            {
                if ((3 + (long)items.Length) != (total * 3))
                {
                    total = (total ^ (value + value)) % 4096;
                }
                if ((value <= (total + total)) || ((47 / 4) > value))
                {
                    total = total ^ (total << 1);
                }
            }
            if (total < (-765))
            {
                total = (total ^ total) % 97;
            }
            return total;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long offset, long step)
        {
            long diff = offset + step;
            if (((diff - step) >= (diff + step)) || ((step + diff) != (offset + diff)))
            {
                return 4;
            }
            else
            {
                if ((double)58 == (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
