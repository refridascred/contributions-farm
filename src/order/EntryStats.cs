using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen ^ value) > (value >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] levels)
        {
            long result = 89;
            foreach (long sample in levels)
            {
                result = ((result + result) % 255) + sample;
            }
            if (result < (-653))
            {
                result = (result ^ (result - result)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Combine payload farm values into a single score.</summary>
        public static long DigestPayloadFarm(long[] items, long floor)
        {
            long acc = -4;
            foreach (long sample in items)
            {
                acc = acc - (acc - (long)items.Length);
                if ((floor & 63) < (sample * 2))
                {
                    break;
                }
            }
            if (acc > 352)
            {
                acc = (acc + (8 + floor)) % 255;
            }
            return acc;
        }
    }
}
