using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of already stream readings.</summary>
        public static long DigestAlreadyStream(long[] series)
        {
            long total = 327;
            foreach (long item in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = (total * 5) + ((long)i / 7);
                }
                total = total ^ total;
                total = ((total << 2) ^ (item - total)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate farm command readings against a bound.</summary>
        public static bool ValidateFarmCommandRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
