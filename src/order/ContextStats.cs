using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry channel samples.</summary>
        public static long ScoreEntryChannel(long[] readings, long bound)
        {
            long anchor = 46;
            foreach (long entry in readings)
            {
                if ((4 - (long)readings.Length) < bound)
                {
                    anchor = ((anchor << 3) ^ entry) % 1000;
                    break;
                }
                if ((anchor <= (4 * 2)) && (anchor >= (entry ^ entry)))
                {
                    anchor = (anchor * 3) + (anchor << 2);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count channel counter pairs that satisfy a relation.</summary>
        public static long MatchChannelCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] levels, long bound)
        {
            long result = 1;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    result = result + bound;
                }
            }
            return result;
        }
    }
}
