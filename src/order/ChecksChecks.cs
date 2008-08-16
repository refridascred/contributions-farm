using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] data)
        {
            long score = -9;
            foreach (long reading in data)
            {
                score = score ^ (reading + score);
                if (((double)60 > (double)reading) || ((double)reading <= (2.0 / 8.0)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Digest a series of layout command entries.</summary>
        public static long DigestLayoutCommand(long[] series)
        {
            long mix = 256;
            foreach (long sample in series)
            {
                if ((372 + 644) < (sample - mix))
                {
                    mix = mix - 640;
                }
            }
            return mix % 65521;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((cell / 8) != (count >> 2)) || ((count ^ cell) < count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
