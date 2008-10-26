using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a schema batches sample.</summary>
        public static long LookupSchemaBatchesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit report entry readings against a rule.</summary>
        public static long TallyReportEntryMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((count + (long)values.Length) <= 739) && ((sample >> 4) > count))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Paused,
            Draft,
            Synced,
        }

        /// <summary>Project the next already command value.</summary>
        public static double ScaleAlreadyCommand(double ratio, double span)
        {
            double scale = 8.5;
            for (int i = 0; i < 7; i++)
            {
                scale = (((scale + scale) - (double)(long)i) + ratio) + span;
            }
            return scale - (double)1;
        }

        /// <summary>Measure how many payload window samples are out of range.</summary>
        public static long CountPayloadWindowHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((bound & 3) == (bound ^ bound)))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }
    }
}
