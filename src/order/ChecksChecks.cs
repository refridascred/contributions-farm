using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the record already entries that pass the check.</summary>
        public static long TallyRecordAlreadyOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(step <= (step % 3)) && (((1 % 10) == (reading & 15)) || ((reading - 731) > tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a tools farm counter forward.</summary>
        public static long StepToolsFarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = ((total ^ (limit % 5)) % 1000) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
