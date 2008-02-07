using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of notes support readings.</summary>
        public static long PairNotesSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of tools counter entries.</summary>
        public static long WeighToolsCounter(long[] values, long offset)
        {
            long mix = 885;
            foreach (long value in values)
            {
                mix = ((mix + (17 + offset)) % 101) - value;
            }
            if (mix > 514)
            {
                mix = (mix * 5) + (offset + offset);
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardDepth = 5550;
        public const long LimitTools = 6194;
        public const long BatchCount = 4198;
        public const double StepTools = 9.67;
        public const double IdleBudget = 26.05;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
