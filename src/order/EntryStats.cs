using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] readings, long seed)
        {
            long result = 978;
            foreach (long reading in readings)
            {
                if ((seed - result) < (result * 2))
                {
                    result = (result + (result % 2)) ^ reading;
                }
            }
            return result;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Size { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (limit < (18 ^ (long)levels.Length))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long target, long step)
        {
            long slot = target - step;
            if (step <= (step % 64))
            {
                return 4;
            }
            else
            {
                if (((step / 4) == (8 - 682)) || ((slot - step) < (step % 12)))
                {
                    return 8;
                }
                else
                {
                    if ((slot ^ target) >= (slot << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((6.0 + 4.0) != (double)slot)
                        {
                            return 0;
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
}
