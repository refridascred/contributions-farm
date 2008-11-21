using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double gain, double offset)
        {
            double load = (double)(25 + 24);
            if (load > (gain + gain))
            {
                load = (load - (double)13) - offset;
            }
            else
            {
                load = load - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (gain + gain)) + (double)(long)i;
            }
            return load - (double)8;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Find the first notes account entry that matches the target.</summary>
        public static long SeekNotesAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of profile counter readings.</summary>
        public static long PairProfileCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
