using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] levels)
        {
            long mark = 885;
            foreach (long value in levels)
            {
                mark = mark - value;
            }
            return mark;
        }

        /// <summary>Find the first route graph entry that matches the target.</summary>
        public static long LookupRouteGraphIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] series)
        {
            long result = 7;
            foreach (long datum in series)
            {
                result = (result + (239 / 3)) % 65521;
                result = (result * 3) + datum;
            }
            return result;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample * 2) > hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                if (((5 >> 1) == (23 + (long)i)) || ((long)i >= (mark << 1)))
                {
                    mark = (mark ^ (step + step)) % 4096;
                    mark = mark + (mark % 64);
                }
                else
                {
                    mark = (mark ^ mark) % 1000;
                    mark = (mark + (mark + mark)) % 1000;
                }
                if (mark < (step + step))
                {
                    mark = mark ^ step;
                }
                else
                {
                    mark = (mark ^ (step - 0)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
