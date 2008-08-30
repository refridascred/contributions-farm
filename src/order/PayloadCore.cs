using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (cell >= (cell + hits))
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

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i >= 92)
                {
                    long diff = (mix / 6) & 1;
                    mix = ((mix << 2) ^ (diff + 78)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] levels)
        {
            long total = 6;
            foreach (long sample in levels)
            {
                total = ((total * 2) + ((-324) - total)) ^ sample;
                total = (total * 3) + (19 % 2);
            }
            if (total < (-71))
            {
                total = (total << 2) ^ total;
            }
            return total;
        }
    }
}
