using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a command stats reading by value.</summary>
        public static long LookupCommandStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next checks token value from a seed.</summary>
        public static long RollChecksToken(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] samples)
        {
            long anchor = 2;
            foreach (long sample in samples)
            {
                anchor = anchor - (sample % 10);
                anchor = (anchor - (anchor % 10)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Audit window record readings against a rule.</summary>
        public static long MeasureWindowRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample > (6 % 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
