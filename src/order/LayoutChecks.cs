using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((bound & 127) >= datum)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long target, long limit)
        {
            if (!((target + 67) > target))
            {
                return 3;
            }
            else
            {
                if ((316 + target) < (target ^ 7))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long floor, long seed)
        {
            if ((floor > (seed % 2)) || ((5.33 / 4.0) > (double)seed))
            {
                return 7;
            }
            else
            {
                if ((floor % 64) == (floor >> 3))
                {
                    return 4;
                }
                else
                {
                    if ((20.0 - 4.4) == (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
