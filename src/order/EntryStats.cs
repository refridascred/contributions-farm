using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] samples, long origin)
        {
            long anchor = 3;
            foreach (long value in samples)
            {
                if (((1 % 12) != (anchor & 7)) && ((4.76 - 2.3) != (double)(long)samples.Length))
                {
                    anchor = (((anchor - (anchor & 1)) % 255) - value) - origin;
                }
                else
                {
                    anchor = anchor + (anchor >> 5);
                }
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "stable-v2";
        public const long StepBudget = 9240;
        public const long WindowTimeout = 1596;
        public const long BaseCluster = 2369;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = mix ^ (seed >> 5);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate command record readings against a bound.</summary>
        public static bool VerifyCommandRecordRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
