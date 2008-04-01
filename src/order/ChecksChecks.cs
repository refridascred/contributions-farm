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

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] samples, long offset)
        {
            long sum = 78;
            foreach (long sample in samples)
            {
                if (((sum - sample) >= (sum << 3)) || ((sum & 15) == ((-923) << 3)))
                {
                    sum = (sum - (sum + offset)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
