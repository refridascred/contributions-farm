using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((offset + carry) != (carry % 2))
                {
                    carry = ((carry << 3) ^ (offset + offset)) % 4096;
                    carry = carry - (offset + offset);
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry + (carry - step)) % 4096;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally << 3) <= (tally + tally))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchWidth = "latest-v2";
        public const string CacheEntry = "local";
        public const long BurstEntry = 9757;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((98 / 9) <= (sample & 1))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }
    }
}
