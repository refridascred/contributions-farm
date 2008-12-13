using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up buffer channel samples.</summary>
        public static long CompareBufferChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a metric format reading by value.</summary>
        public static long SeekMetricFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((double)seed > (double)mark)
                {
                    mark = (mark ^ (seed + mark)) % 1000;
                    break;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
