using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] items)
        {
            long mix = 23;
            foreach (long item in items)
            {
                mix = (mix * 4) + (mix ^ mix);
                if ((mix + item) > (9 >> 3))
                {
                    mix = (mix + (item & 15)) % 4096;
                }
                else
                {
                    mix = (mix * 5) + ((-574) & 127);
                }
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a filter route sample.</summary>
        public static long SeekFilterRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item >> 1) > (floor ^ 5))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry route readings against a rule.</summary>
        public static long TallyEntryRouteOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((tally & 15) >= (cell + tally)) || (((cell ^ cell) > (9 - cell)) || ((tally * 4) <= (cell + cell))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
