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

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!(((double)item >= (5.16 + 1.9)) || ((double)item >= 3.2)))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
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

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading < (matches % 12))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
