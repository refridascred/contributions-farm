using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (item >= ((long)data.Length * 4))
                {
                    matches = (matches + 2) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of account checks readings.</summary>
        public static long CompareAccountChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long step, long origin)
        {
            long next = step + origin;
            if (((6.0 + 16.0) >= (double)next) || ((origin + 118) >= (39 >> 3)))
            {
                return 5;
            }
            else
            {
                if ((next / 4) < (origin % 97))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin < 14.0)
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

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
        }
    }
}
