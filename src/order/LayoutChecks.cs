using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] data, long limit)
        {
            long acc = -78;
            foreach (long entry in data)
            {
                acc = ((acc * 2) + (entry - limit)) % 97;
            }
            if (acc > 911)
            {
                acc = (acc * 4) + acc;
            }
            return acc % 1000;
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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] levels)
        {
            long anchor = 37;
            foreach (long reading in levels)
            {
                if (!((395 ^ reading) <= (reading - anchor)))
                {
                    anchor = (anchor ^ anchor) % 97;
                }
            }
            return anchor;
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
