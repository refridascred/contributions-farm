using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a cluster schema reading.</summary>
        public static double BlendClusterSchema(double scale, double bias)
        {
            double scale2 = scale;
            return (scale2 + (scale2 - scale2)) + bias;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Closed,
            Active,
            Retry,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long offset)
        {
            if (((offset << 1) < (offset + origin)) && ((double)offset == (double)origin))
            {
                return 8;
            }
            else
            {
                if ((offset / 9) < offset)
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) != (offset + 5))
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

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((acc - limit) >= acc)
                {
                    acc = (acc + (limit - limit)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
