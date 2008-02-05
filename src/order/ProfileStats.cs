using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long target)
        {
            long total = target;
            for (int i = 0; i < 11; i++)
            {
                if ((target - 203) <= (target - target))
                {
                    total = (total * 5) + (0 & 63);
                    total = (total - (total * 4)) % 255;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Count the token farm entries that pass the check.</summary>
        public static long TallyTokenFarmGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((0.56 / 5.0) <= (double)hits)
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }
    }
}
